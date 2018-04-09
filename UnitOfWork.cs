using Marten;
using Marten.Events;
using MartenHelp.Projections;
using System.Reflection;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MartenHelp
{
    public class UnitOfWork : IUnitOfWork, IDisposable 
    {
        private IDocumentStore _store;

        private IDocumentSession session;

        #region Constructors
       
        public UnitOfWork(string connectionString, EnvironmentType env)
        {
            _store = StoreFactory.CreateDocumentStore(connectionString, env);
            if (!StartSession()) {
                throw new Exception("Could not start session.");
            }
        }

        public UnitOfWork(IDocumentStore DocumentStore)
        {
            _store = DocumentStore;
            if (!StartSession()) {
                throw new Exception("Could not start session.");
            }            
        }
        #endregion

        private Boolean StartSession()
        {
            this.session = _store.LightweightSession();
            return this.session.Connection != null;
        }

        public void Dispose()
        {
            EndSession();
        }

        private Boolean EndSession()
        {
            if (this.session != null)
            {
                this.session.Dispose();
            }
            return true;
        }

        public async Task<T> AppendEvent<T>(Guid StreamId, MartenHelp.Events.Event newEvent) where T : class, new()
        {
            this.session.Events.Append(StreamId, newEvent);
            var stream = await this.session.Events.AggregateStreamAsync<T>(StreamId);
            return stream;
        }

        public async Task<T> GetStreamState<T>(Guid StreamId) where T : class, new()
        {
            return await this.session.Events.AggregateStreamAsync<T>(StreamId);
        }

        public async Task SaveChanges()
        {
            await this.session.SaveChangesAsync();
        }

        public IQueryable<T> CreateQueryable<T>() where T : class, new()
        {
            return session.Query<T>();
        }

        public async Task<Guid> CreateNewStream<T>() where T: class, new()
        {
            var id = this.session.Events.StartStream<T>().Id;
            return id;
        }

        public async Task<Guid> CreateNewStream<T>(params Events.Event[] events) where T: class, new()
        {
            var id = this.session.Events.StartStream<T>(events).Id;            
            return id;
        }
    }

    public enum EnvironmentType {dev, qa, prod}
}