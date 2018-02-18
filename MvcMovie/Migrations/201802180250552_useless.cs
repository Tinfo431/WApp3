namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class useless : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Rating", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Rating");
        }
    }
}
