using System.Data.Entity;
using System.Threading.Tasks;
using Less.Sup.WebApi.Models;

namespace Less.Sup.WebApi.Tests.Database
{
    public class TestSupContext : ISupContext
    {
        public TestSupContext()
        {
            Routes = new TestRouteDbSet();
            InsertTestData();
        }

        public DbSet<Route> Routes { get; set; }
        public DbSet<WayPoint> WayPoints { get; set; }
        public DbSet<Location> Locations{ get; set; }

        public Task<int> SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose() { }

        
        private void InsertTestData()
        {
            Routes.Add(new Route
            {
                Id = 1,
                Name = "TestRoute1"
            });

            Routes.Add(new Route
            {
                Id = 2,
                Name = "TestRoute2"
            });
        }

    }
}
