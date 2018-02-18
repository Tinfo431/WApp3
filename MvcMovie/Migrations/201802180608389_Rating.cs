namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rating : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Rating", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Rating", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
