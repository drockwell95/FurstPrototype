namespace Furst_Alpha_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItsANewDay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Models", "Image", c => c.String());
            DropColumn("dbo.Assets", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Assets", "Image", c => c.String());
            DropColumn("dbo.Models", "Image");
        }
    }
}
