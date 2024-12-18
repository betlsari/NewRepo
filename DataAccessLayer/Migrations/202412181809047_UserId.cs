namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserId : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Favoris", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Favoris", "UserId", c => c.Int(nullable: false));
        }
    }
}
