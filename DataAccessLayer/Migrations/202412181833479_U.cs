namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class U : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Favoris", "IsFavorite", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Favoris", "IsFavorite");
        }
    }
}
