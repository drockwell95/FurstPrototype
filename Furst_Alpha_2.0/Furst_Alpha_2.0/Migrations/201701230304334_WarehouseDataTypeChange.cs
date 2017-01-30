namespace Furst_Alpha_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WarehouseDataTypeChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.VendorWarehouses", "Latitude", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.VendorWarehouses", "Longitude", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.VendorWarehouses", "Longitude", c => c.Double(nullable: false));
            AlterColumn("dbo.VendorWarehouses", "Latitude", c => c.Double(nullable: false));
        }
    }
}
