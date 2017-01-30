namespace Furst_Alpha_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NearbyVendors : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VendorWarehouses", "AddressLatitude", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.VendorWarehouses", "AddressLongitude", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.VendorWarehouses", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.VendorWarehouses", "Discriminator");
            DropColumn("dbo.VendorWarehouses", "AddressLongitude");
            DropColumn("dbo.VendorWarehouses", "AddressLatitude");
        }
    }
}
