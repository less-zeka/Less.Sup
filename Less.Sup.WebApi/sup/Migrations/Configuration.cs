using System.Data.Entity.Migrations;
using System.Data.Entity.Spatial;
using Less.Sup.WebApi.Models;

namespace Less.Sup.WebApi.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SupContext>
    {
        protected override void Seed(SupContext context)
        {
            var schiffenen = new Route{Name = "Schiffenen"};

            #region schiffenenLocations
            var schiffenen1 = new WayPoint
            {
                Info = "Start",
                Latitude = 46.806323,
                Longitude= 7.166031,
                Route = schiffenen,
                DbGeography = DbGeography.FromText("POINT(46.806323 7.166031)")
            };
            var schiffenen2 = new WayPoint
            {
                Info = "WegPunkt",
                Latitude = 46.813138,
                Longitude= 7.165129,
                Route = schiffenen,
                DbGeography = DbGeography.FromText("POINT(46.813138 7.165129)")
            };
            var schiffenen3 = new WayPoint
            {
                Info = "Ende",
                Latitude = 46.861753,
                Longitude = 7.179978,
                Route = schiffenen,
                DbGeography = DbGeography.FromText("POINT(46.861753 7.179978)")
            };
            #endregion
            var bernBremgarten = new Route { Name = "Bern-Bremgarten" };

            #region BernBremgartenLocations
            var bern1 = new WayPoint
            {
                Info = "Start",
                Latitude = 46.954318,
                Longitude = 7.441991,
                Route = bernBremgarten,
                DbGeography = DbGeography.FromText("POINT(46.954318 7.441991)")
            };
            var bern2 = new WayPoint
            {
                Info = "WegPunkt1",
                Latitude = 46.977016,
                Longitude = 7.457097,
                Route = bernBremgarten,
                DbGeography = DbGeography.FromText("POINT(46.977016 7.457097)")
            };
            var bern3 = new WayPoint
            {
                Info = "WegPunkt2",
                Latitude = 46.972448, 
                Longitude= 7.439373,
                Route = bernBremgarten,
                DbGeography = DbGeography.FromText("POINT(46.972448 7.439373)")
            };
            var bern4 = new WayPoint
            {
                Info = "Ende",
                Latitude = 46.971379,
                Longitude= 7.417358,
                Route = bernBremgarten,
                DbGeography = DbGeography.FromText("POINT(46.971379 7.417358)")
            };
            #endregion
            context.Routes.AddOrUpdate(schiffenen);
            context.Routes.AddOrUpdate(bernBremgarten);

            context.WayPoints.AddOrUpdate(schiffenen1);
            context.WayPoints.AddOrUpdate(schiffenen2);
            context.WayPoints.AddOrUpdate(schiffenen3);

            context.WayPoints.AddOrUpdate(bern1);
            context.WayPoints.AddOrUpdate(bern2);
            context.WayPoints.AddOrUpdate(bern3);
            context.WayPoints.AddOrUpdate(bern4);
        }
    }
}
