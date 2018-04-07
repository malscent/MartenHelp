using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Marten;
using Marten.Events.Projections;

namespace MartenHelp
{
    internal class StoreFactory
    {
        private static object syncRoot = new Object();
        private static volatile Dictionary<string, IDocumentStore> stores = new Dictionary<string, IDocumentStore>();

        private static Type[] EventTypes = new Type[0];
        private static Type[] ProjectionTypes = new Type[0];

        public static IDocumentStore CreateDocumentStore(string connectionString, EnvironmentType env)
        {
            if (!stores.Keys.Contains(connectionString))
            {
                lock (syncRoot)
                {
                    if (!stores.Keys.Contains(connectionString))
                    {
                        stores.Add(connectionString, GenerateDocumentStore(connectionString, env));
                    }
                }
            }
            return stores[connectionString];
        }

        private static IDocumentStore GenerateDocumentStore(string connectionString, EnvironmentType env)
        {
            if (ProjectionTypes == null | ProjectionTypes.Length == 0)
            {
                ProjectionTypes = GetEventTypes(typeof(UnitOfWork).GetTypeInfo().Assembly, "tx.DataAccessLayer.Projections");
            }
            if (EventTypes == null || EventTypes.Length == 0)
            {
                EventTypes = GetEventTypes(typeof(UnitOfWork).GetTypeInfo().Assembly, "tx.DataAccessLayer.Events");
            }
            var autoCreate = (env == EnvironmentType.dev) ? AutoCreate.All : AutoCreate.CreateOrUpdate;
            IDocumentStore _store = DocumentStore.For(_ =>
            {

                _.AutoCreateSchemaObjects = autoCreate;
                _.Connection(connectionString);
            });
            EventTypes.ToList().ForEach(Event =>
            {
                if (!Event.GetTypeInfo().IsAbstract && Event.GetTypeInfo().IsClass)
                    _store.Events.AddEventType(Event);
            });
            var inline = typeof(Marten.Events.Projections.ProjectionCollection);
            MethodInfo method = inline.GetMethod("AggregateStreamsWith");
            ProjectionTypes.ToList().ForEach(Projection =>
            {
                // Only Register if it is not abstract, is a class, and implements IProjection
                if (!Projection.GetTypeInfo().IsAbstract && Projection.GetTypeInfo().IsClass && typeof(IProjection).IsAssignableFrom(Projection))
                {
                    MethodInfo genericMethod = method.MakeGenericMethod(Projection);
                    genericMethod.Invoke(_store.Events.InlineProjections, null);
                }
            });
            return _store;
        }

        private static Type[] GetEventTypes(Assembly assembly, string nameSpace)
        {
            return assembly.GetTypes().Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal)).ToArray();
        }

    }
}