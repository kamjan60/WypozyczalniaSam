namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodanieDostepnosci : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "isInStock", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "isInStock");
        }
    }
}
