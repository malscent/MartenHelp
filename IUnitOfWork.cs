using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marten.Events.Projections;

namespace MartenHelp
{
    public interface IUnitOfWork
    {
        Task<Guid> CreateNewStream<T>()  where T: class, new();
        Task<Guid> CreateNewStream<T>(params Events.Event[] events) where T: class, new();
        Task<T> AppendEvent<T>(Guid StreamId, MartenHelp.Events.Event newEvent)  where T : class, new();
        Task<T> GetStreamState<T>(Guid StreamId) where T : class, new();
        
        Task SaveChanges();
        IQueryable<T> CreateQueryable<T>() where T : class, new();

    }
}
