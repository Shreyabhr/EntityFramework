namespace ConsoleEFFrameworkApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V4_typeAdd3_Customer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Type3", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Type3");
        }
    }
}
