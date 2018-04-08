using System;
using System.Linq;
using Marten;
using MartenHelp.Events;
using MartenHelp.Projections;
using Xunit;

namespace MartenHelp
{
    public class FailingTests
    {

        private string CONNECTION_STRING = "host=localhost;database=marten_test_error;password=sdiqpids;username=postgres";

        [Fact]
        public async void Test1()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);
            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        }
        [Fact]
        public async void Test2()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        }
        [Fact]
        public async void Test3()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        }
        [Fact]
        public async void Test4()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        }
        [Fact]
        public async void Test5()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        
        }
        [Fact]
        public async void Test6()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        
        }
        [Fact]
        public async void Test7()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        
        } 
        [Fact]
        public async void Test8()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        } 
        [Fact]
        public async void Test9()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        
        } 

        [Fact]
        public async void Test10()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        
        } 
        [Fact]
        public async void Test11()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        
        }
        [Fact]
        public async void Test12()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        }  
        [Fact]
        public async void Test13()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        
        }  
        [Fact]
        public async void Test14()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        
        }  

        [Fact]
        public async void Test15()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        }  
        [Fact]
        public async void Test16()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        }
        [Fact]
        public async void Test17()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        }
        [Fact]
        public async void Test18()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        }
        [Fact]
        public async void Test19()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        }
        [Fact]
        public async void Test20()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        }
        [Fact]
        public async void Test21()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        
        }
        [Fact]
        public async void Test22()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        
        }
        [Fact]
        public async void Test23()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        
        } 
        [Fact]
        public async void Test24()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        
        } 
        [Fact]
        public async void Test25()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        } 

        [Fact]
        public async void Test26()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        
        } 
        [Fact]
        public async void Test27()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        }
        [Fact]
        public async void Test28()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        
        }  
        [Fact]
        public async void Test29()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        
        }  
        [Fact]
        public async void Test30()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        
        }  

        [Fact]
        public async void Test31()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        
        }  
        [Fact]
        public async void Test32()
        {
            var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev);

            var e = new Event();
            var id = await uow.CreateNewStream<SimpleProjection>(e);
            Console.WriteLine(id);
            await uow.SaveChanges();
            var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
            var entity = entityList.FirstOrDefault();
            Assert.True(entity.Id == id);
        
        }                                                                                                                                      
    }
}
