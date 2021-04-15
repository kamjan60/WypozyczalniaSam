namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodaniePolaCarRegistration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "CarRegistration", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "CarRegistration");
        }
    }
}
