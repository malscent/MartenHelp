using System;
using System.Linq;
using Marten;
using MartenHelp.Events;
using MartenHelp.Projections;
using Xunit;

namespace MartenHelp
{
    public class SucceedTests
    {

        private string CONNECTION_STRING = "host=localhost;database=marten_test_error;password=sdiqpids;username=postgres";

        [Fact]
        public async void Test1()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        }
        [Fact]
        public async void Test2()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        }
        [Fact]
        public async void Test3()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        }
        [Fact]
        public async void Test4()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        }
        [Fact]
        public async void Test5()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        }
        [Fact]
        public async void Test6()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        }
        [Fact]
        public async void Test7()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        } 
        [Fact]
        public async void Test8()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        } 
        [Fact]
        public async void Test9()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        } 

        [Fact]
        public async void Test10()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        } 
        [Fact]
        public async void Test11()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        }
        [Fact]
        public async void Test12()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        }  
        [Fact]
        public async void Test13()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        }  
        [Fact]
        public async void Test14()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        }  

        [Fact]
        public async void Test15()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        }  
        [Fact]
        public async void Test16()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        }
        [Fact]
        public async void Test17()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        }
        [Fact]
        public async void Test18()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        }
        [Fact]
        public async void Test19()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        }
        [Fact]
        public async void Test20()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        }
        [Fact]
        public async void Test21()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        }
        [Fact]
        public async void Test22()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        }
        [Fact]
        public async void Test23()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        } 
        [Fact]
        public async void Test24()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        } 
        [Fact]
        public async void Test25()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        } 

        [Fact]
        public async void Test26()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        } 
        [Fact]
        public async void Test27()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        }
        [Fact]
        public async void Test28()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        }  
        [Fact]
        public async void Test29()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        }  
        [Fact]
        public async void Test30()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        }  

        [Fact]
        public async void Test31()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
                var e = new Event();
                var id = await uow.CreateNewStream<SimpleProjection>(e);
                Console.WriteLine(id);
                await uow.SaveChanges();
                var entityList = await uow.CreateQueryable<SimpleProjection>().Where((x) => x.Id == id).ToListAsync();
                var entity = entityList.FirstOrDefault();
                Assert.True(entity.Id == id);
            }
        
        }  
        [Fact]
        public async void Test32()
        {
            using (var uow = new UnitOfWork(CONNECTION_STRING, EnvironmentType.dev))
            {
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
}
