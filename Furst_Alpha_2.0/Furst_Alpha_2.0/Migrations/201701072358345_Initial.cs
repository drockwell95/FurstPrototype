namespace Furst_Alpha_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assets",
                c => new
                    {
                        AssetId = c.Int(nullable: false, identity: true),
                        Barcode = c.String(),
                        Image = c.String(),
                        YearPurchased = c.Int(nullable: false),
                        RentalPrice = c.Double(nullable: false),
                        NumTechsReq = c.Int(nullable: false),
                        Availability = c.Boolean(nullable: false),
                        Category_CategoryId = c.Int(),
                        Make_MakeId = c.Int(),
                        Model_ModelId = c.Int(),
                        Type_TypeId = c.Int(),
                        Vendor_VendorId = c.Int(),
                    })
                .PrimaryKey(t => t.AssetId)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId)
                .ForeignKey("dbo.Makes", t => t.Make_MakeId)
                .ForeignKey("dbo.Models", t => t.Model_ModelId)
                .ForeignKey("dbo.Types", t => t.Type_TypeId)
                .ForeignKey("dbo.Vendors", t => t.Vendor_VendorId)
                .Index(t => t.Category_CategoryId)
                .Index(t => t.Make_MakeId)
                .Index(t => t.Model_ModelId)
                .Index(t => t.Type_TypeId)
                .Index(t => t.Vendor_VendorId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Makes",
                c => new
                    {
                        MakeId = c.Int(nullable: false, identity: true),
                        MakeName = c.String(),
                    })
                .PrimaryKey(t => t.MakeId);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        ModelId = c.Int(nullable: false, identity: true),
                        ModelName = c.String(),
                    })
                .PrimaryKey(t => t.ModelId);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        TypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.TypeId);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        VendorId = c.Int(nullable: false, identity: true),
                        VendorName = c.String(),
                    })
                .PrimaryKey(t => t.VendorId);
            
            CreateTable(
                "dbo.Quantities",
                c => new
                    {
                        QuantityId = c.Int(nullable: false, identity: true),
                        total = c.Int(nullable: false),
                        InUse = c.Int(nullable: false),
                        Make_MakeId = c.Int(),
                        Model_ModelId = c.Int(),
                        Vendor_VendorId = c.Int(),
                    })
                .PrimaryKey(t => t.QuantityId)
                .ForeignKey("dbo.Makes", t => t.Make_MakeId)
                .ForeignKey("dbo.Models", t => t.Model_ModelId)
                .ForeignKey("dbo.Vendors", t => t.Vendor_VendorId)
                .Index(t => t.Make_MakeId)
                .Index(t => t.Model_ModelId)
                .Index(t => t.Vendor_VendorId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Quantities", "Vendor_VendorId", "dbo.Vendors");
            DropForeignKey("dbo.Quantities", "Model_ModelId", "dbo.Models");
            DropForeignKey("dbo.Quantities", "Make_MakeId", "dbo.Makes");
            DropForeignKey("dbo.Assets", "Vendor_VendorId", "dbo.Vendors");
            DropForeignKey("dbo.Assets", "Type_TypeId", "dbo.Types");
            DropForeignKey("dbo.Assets", "Model_ModelId", "dbo.Models");
            DropForeignKey("dbo.Assets", "Make_MakeId", "dbo.Makes");
            DropForeignKey("dbo.Assets", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Quantities", new[] { "Vendor_VendorId" });
            DropIndex("dbo.Quantities", new[] { "Model_ModelId" });
            DropIndex("dbo.Quantities", new[] { "Make_MakeId" });
            DropIndex("dbo.Assets", new[] { "Vendor_VendorId" });
            DropIndex("dbo.Assets", new[] { "Type_TypeId" });
            DropIndex("dbo.Assets", new[] { "Model_ModelId" });
            DropIndex("dbo.Assets", new[] { "Make_MakeId" });
            DropIndex("dbo.Assets", new[] { "Category_CategoryId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Quantities");
            DropTable("dbo.Vendors");
            DropTable("dbo.Types");
            DropTable("dbo.Models");
            DropTable("dbo.Makes");
            DropTable("dbo.Categories");
            DropTable("dbo.Assets");
        }
    }
}
