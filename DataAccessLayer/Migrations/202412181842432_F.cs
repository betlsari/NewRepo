namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class F : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Favoris", "CarId", "dbo.Cars");
            DropIndex("dbo.Favoris", new[] { "CarId" });
            CreateTable(
                "dbo.Favorites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .Index(t => t.CarId);
            
            DropTable("dbo.Favoris");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Favoris",
                c => new
                    {
                        FavoriId = c.Int(nullable: false, identity: true),
                        CarId = c.Int(nullable: false),
                        IsFavorite = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FavoriId);
            
            DropForeignKey("dbo.Favorites", "CarId", "dbo.Cars");
            DropIndex("dbo.Favorites", new[] { "CarId" });
            DropTable("dbo.Favorites");
            CreateIndex("dbo.Favoris", "CarId");
            AddForeignKey("dbo.Favoris", "CarId", "dbo.Cars", "CarId", cascadeDelete: true);
        }
    }
}
