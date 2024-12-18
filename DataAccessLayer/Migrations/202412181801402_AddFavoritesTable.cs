namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFavoritesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Favoris",
                c => new
                    {
                        FavoriId = c.Int(nullable: false, identity: true),
                        CarId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FavoriId)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .Index(t => t.CarId);
            
            DropTable("dbo.Favorites");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Favorites",
                c => new
                    {
                        FavoriteId = c.Int(nullable: false, identity: true),
                        CarId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FavoriteId);
            
            DropForeignKey("dbo.Favoris", "CarId", "dbo.Cars");
            DropIndex("dbo.Favoris", new[] { "CarId" });
            DropTable("dbo.Favoris");
        }
    }
}
