namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodaniePosterName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "PosterName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "PosterName");
        }
    }
}
