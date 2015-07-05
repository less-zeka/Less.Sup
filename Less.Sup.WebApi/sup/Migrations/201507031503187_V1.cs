namespace Less.Sup.WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WayPoints",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DbGeography = c.Geography(),
                        Longitude = c.Double(nullable: false),
                        Latitude = c.Double(nullable: false),
                        Info = c.String(),
                        RouteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Routes", t => t.RouteId, cascadeDelete: true)
                .Index(t => t.RouteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WayPoints", "RouteId", "dbo.Routes");
            DropIndex("dbo.WayPoints", new[] { "RouteId" });
            DropTable("dbo.WayPoints");
            DropTable("dbo.Routes");
        }
    }
}
