using System.Data.Entity;
using System.Threading.Tasks;

namespace Less.Sup.WebApi.Models
{
    public class SupContext : DbContext, ISupContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<Sup.Models.SupContext>());

        public SupContext() : base("name=SupContext")
        {
        }

        public DbSet<WayPoint> WayPoints{ get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Location> Locations { get; set; }

        public override Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        //public DbEntityEntry<Route> Entry { get; set; }
    }
}
