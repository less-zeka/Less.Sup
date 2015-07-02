namespace Less.Sup.WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class U1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Locations", "RouteId", "dbo.Routes");
            DropIndex("dbo.Locations", new[] { "RouteId" });
            DropTable("dbo.Locations");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Point = c.Geography(),
                        Longitude = c.Double(nullable: false),
                        Latitude = c.Double(nullable: false),
                        Info = c.String(),
                        RouteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Locations", "RouteId");
            AddForeignKey("dbo.Locations", "RouteId", "dbo.Routes", "Id", cascadeDelete: true);
        }
    }
}
