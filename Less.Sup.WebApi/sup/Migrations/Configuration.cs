using System.Data.Entity.Spatial;

namespace Sup.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.SupContext>
    {
        public Configuration()
        {
            //AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Models.SupContext context)
        {
            var schiffenen = new Models.Route{Name = "Schiffenen"};

            #region schiffenenLocations
            var schiffenen1 = new Models.Location
            {
                Info = "Start",
                Latitude = 46.806323,
                Longitude= 7.166031,
                Route = schiffenen,
                Point = DbGeography.FromText("POINT(46.806323 7.166031)")
            };
            var schiffenen2 = new Models.Location
            {
                Info = "WegPunkt",
                Latitude = 46.813138,
                Longitude= 7.165129,
                Route = schiffenen,
                Point = DbGeography.FromText("POINT(46.813138 7.165129)")
            };
            var schiffenen3 = new Models.Location
            {
                Info = "Ende",
                Latitude = 46.861753,
                Longitude = 7.179978,
                Route = schiffenen,
                Point = DbGeography.FromText("POINT(46.861753 7.179978)")
            };
            #endregion
            var bernBremgarten = new Models.Route { Name = "Bern-Bremgarten" };

            #region BernBremgartenLocations
            var bern1 = new Models.Location
            {
                Info = "Start",
                Latitude = 46.954318,
                Longitude = 7.441991,
                Route = bernBremgarten,
                Point = DbGeography.FromText("POINT(46.954318 7.441991)")
            };
            var bern2 = new Models.Location
            {
                Info = "WegPunkt1",
                Latitude = 46.977016,
                Longitude = 7.457097,
                Route = bernBremgarten,
                Point = DbGeography.FromText("POINT(46.977016 7.457097)")
            };
            var bern3 = new Models.Location
            {
                Info = "WegPunkt2",
                Latitude = 46.972448, 
                Longitude= 7.439373,
                Route = bernBremgarten,
                Point = DbGeography.FromText("POINT(46.972448 7.439373)")
            };
            var bern4 = new Models.Location
            {
                Info = "Ende",
                Latitude = 46.971379,
                Longitude= 7.417358,
                Route = bernBremgarten,
                Point = DbGeography.FromText("POINT(46.971379 7.417358)")
            };
            #endregion
            context.Routes.AddOrUpdate(schiffenen);
            context.Routes.AddOrUpdate(bernBremgarten);

            context.Locations.AddOrUpdate(schiffenen1);
            context.Locations.AddOrUpdate(schiffenen2);
            context.Locations.AddOrUpdate(schiffenen3);

            context.Locations.AddOrUpdate(bern1);
            context.Locations.AddOrUpdate(bern2);
            context.Locations.AddOrUpdate(bern3);
            context.Locations.AddOrUpdate(bern4);
        }
    }
}
