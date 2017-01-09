namespace Furst_Alpha_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewBarcode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vendors", "NextBarcode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vendors", "NextBarcode");
        }
    }
}
