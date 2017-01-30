namespace Furst_Alpha_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWarehouses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VendorWarehouses",
                c => new
                    {
                        VendorWarehouseId = c.Int(nullable: false, identity: true),
                        Address = c.String(nullable: false),
                        City = c.String(nullable: false),
                        Region = c.String(nullable: false),
                        CountryCode = c.String(nullable: false),
                        PostalCode = c.String(nullable: false),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                        Vendor_VendorId = c.Int(),
                    })
                .PrimaryKey(t => t.VendorWarehouseId)
                .ForeignKey("dbo.Vendors", t => t.Vendor_VendorId)
                .Index(t => t.Vendor_VendorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VendorWarehouses", "Vendor_VendorId", "dbo.Vendors");
            DropIndex("dbo.VendorWarehouses", new[] { "Vendor_VendorId" });
            DropTable("dbo.VendorWarehouses");
        }
    }
}
