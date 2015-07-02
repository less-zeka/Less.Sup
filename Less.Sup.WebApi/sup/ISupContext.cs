using System;
using System.Data.Entity;
using System.Threading.Tasks;
using Less.Sup.WebApi.Models;

namespace Less.Sup.WebApi
{
    public interface ISupContext : IDisposable
    {
        DbSet<WayPoint> WayPoints { get; set; }
        DbSet<Route> Routes { get; set; }
        DbSet<Location> Locations { get; set; }

        Task<int> SaveChangesAsync();

        //DbEntityEntry<Route> Entry { get; set; }
    }
}