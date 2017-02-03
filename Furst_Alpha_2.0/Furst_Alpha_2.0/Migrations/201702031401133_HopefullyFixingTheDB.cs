namespace Furst_Alpha_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HopefullyFixingTheDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Assets", "Category_CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Assets", "Make_MakeId", "dbo.Makes");
            DropForeignKey("dbo.Assets", "Model_ModelId", "dbo.Models");
            DropForeignKey("dbo.Assets", "Type_TypeId", "dbo.Types");
            DropForeignKey("dbo.Assets", "Vendor_VendorId", "dbo.Vendors");
            DropForeignKey("dbo.VendorWarehouses", "Vendor_VendorId", "dbo.Vendors");
            DropForeignKey("dbo.Quantities", "Make_MakeId", "dbo.Makes");
            DropForeignKey("dbo.Quantities", "Model_ModelId", "dbo.Models");
            DropForeignKey("dbo.Quantities", "Vendor_VendorId", "dbo.Vendors");
            DropIndex("dbo.Assets", new[] { "Category_CategoryId" });
            DropIndex("dbo.Assets", new[] { "Make_MakeId" });
            DropIndex("dbo.Assets", new[] { "Model_ModelId" });
            DropIndex("dbo.Assets", new[] { "Type_TypeId" });
            DropIndex("dbo.Assets", new[] { "Vendor_VendorId" });
            DropIndex("dbo.VendorWarehouses", new[] { "Vendor_VendorId" });
            DropIndex("dbo.Quantities", new[] { "Make_MakeId" });
            DropIndex("dbo.Quantities", new[] { "Model_ModelId" });
            DropIndex("dbo.Quantities", new[] { "Vendor_VendorId" });
            RenameColumn(table: "dbo.Assets", name: "Category_CategoryId", newName: "CategoryId");
            RenameColumn(table: "dbo.Assets", name: "Make_MakeId", newName: "MakeId");
            RenameColumn(table: "dbo.Assets", name: "Model_ModelId", newName: "ModelId");
            RenameColumn(table: "dbo.Assets", name: "Type_TypeId", newName: "TypeId");
            RenameColumn(table: "dbo.Assets", name: "Vendor_VendorId", newName: "VendorId");
            RenameColumn(table: "dbo.VendorWarehouses", name: "Vendor_VendorId", newName: "VendorId");
            RenameColumn(table: "dbo.Quantities", name: "Make_MakeId", newName: "MakeId");
            RenameColumn(table: "dbo.Quantities", name: "Model_ModelId", newName: "ModelId");
            RenameColumn(table: "dbo.Quantities", name: "Vendor_VendorId", newName: "VendorId");
            AlterColumn("dbo.Assets", "CategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Assets", "MakeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Assets", "ModelId", c => c.Int(nullable: false));
            AlterColumn("dbo.Assets", "TypeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Assets", "VendorId", c => c.Int(nullable: false));
            AlterColumn("dbo.VendorWarehouses", "VendorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Quantities", "MakeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Quantities", "ModelId", c => c.Int(nullable: false));
            AlterColumn("dbo.Quantities", "VendorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Assets", "VendorId");
            CreateIndex("dbo.Assets", "CategoryId");
            CreateIndex("dbo.Assets", "TypeId");
            CreateIndex("dbo.Assets", "MakeId");
            CreateIndex("dbo.Assets", "ModelId");
            CreateIndex("dbo.VendorWarehouses", "VendorId");
            CreateIndex("dbo.Quantities", "VendorId");
            CreateIndex("dbo.Quantities", "MakeId");
            CreateIndex("dbo.Quantities", "ModelId");
            AddForeignKey("dbo.Assets", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
            AddForeignKey("dbo.Assets", "MakeId", "dbo.Makes", "MakeId", cascadeDelete: true);
            AddForeignKey("dbo.Assets", "ModelId", "dbo.Models", "ModelId", cascadeDelete: true);
            AddForeignKey("dbo.Assets", "TypeId", "dbo.Types", "TypeId", cascadeDelete: true);
            AddForeignKey("dbo.Assets", "VendorId", "dbo.Vendors", "VendorId", cascadeDelete: true);
            AddForeignKey("dbo.VendorWarehouses", "VendorId", "dbo.Vendors", "VendorId", cascadeDelete: true);
            AddForeignKey("dbo.Quantities", "MakeId", "dbo.Makes", "MakeId", cascadeDelete: true);
            AddForeignKey("dbo.Quantities", "ModelId", "dbo.Models", "ModelId", cascadeDelete: true);
            AddForeignKey("dbo.Quantities", "VendorId", "dbo.Vendors", "VendorId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Quantities", "VendorId", "dbo.Vendors");
            DropForeignKey("dbo.Quantities", "ModelId", "dbo.Models");
            DropForeignKey("dbo.Quantities", "MakeId", "dbo.Makes");
            DropForeignKey("dbo.VendorWarehouses", "VendorId", "dbo.Vendors");
            DropForeignKey("dbo.Assets", "VendorId", "dbo.Vendors");
            DropForeignKey("dbo.Assets", "TypeId", "dbo.Types");
            DropForeignKey("dbo.Assets", "ModelId", "dbo.Models");
            DropForeignKey("dbo.Assets", "MakeId", "dbo.Makes");
            DropForeignKey("dbo.Assets", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Quantities", new[] { "ModelId" });
            DropIndex("dbo.Quantities", new[] { "MakeId" });
            DropIndex("dbo.Quantities", new[] { "VendorId" });
            DropIndex("dbo.VendorWarehouses", new[] { "VendorId" });
            DropIndex("dbo.Assets", new[] { "ModelId" });
            DropIndex("dbo.Assets", new[] { "MakeId" });
            DropIndex("dbo.Assets", new[] { "TypeId" });
            DropIndex("dbo.Assets", new[] { "CategoryId" });
            DropIndex("dbo.Assets", new[] { "VendorId" });
            AlterColumn("dbo.Quantities", "VendorId", c => c.Int());
            AlterColumn("dbo.Quantities", "ModelId", c => c.Int());
            AlterColumn("dbo.Quantities", "MakeId", c => c.Int());
            AlterColumn("dbo.VendorWarehouses", "VendorId", c => c.Int());
            AlterColumn("dbo.Assets", "VendorId", c => c.Int());
            AlterColumn("dbo.Assets", "TypeId", c => c.Int());
            AlterColumn("dbo.Assets", "ModelId", c => c.Int());
            AlterColumn("dbo.Assets", "MakeId", c => c.Int());
            AlterColumn("dbo.Assets", "CategoryId", c => c.Int());
            RenameColumn(table: "dbo.Quantities", name: "VendorId", newName: "Vendor_VendorId");
            RenameColumn(table: "dbo.Quantities", name: "ModelId", newName: "Model_ModelId");
            RenameColumn(table: "dbo.Quantities", name: "MakeId", newName: "Make_MakeId");
            RenameColumn(table: "dbo.VendorWarehouses", name: "VendorId", newName: "Vendor_VendorId");
            RenameColumn(table: "dbo.Assets", name: "VendorId", newName: "Vendor_VendorId");
            RenameColumn(table: "dbo.Assets", name: "TypeId", newName: "Type_TypeId");
            RenameColumn(table: "dbo.Assets", name: "ModelId", newName: "Model_ModelId");
            RenameColumn(table: "dbo.Assets", name: "MakeId", newName: "Make_MakeId");
            RenameColumn(table: "dbo.Assets", name: "CategoryId", newName: "Category_CategoryId");
            CreateIndex("dbo.Quantities", "Vendor_VendorId");
            CreateIndex("dbo.Quantities", "Model_ModelId");
            CreateIndex("dbo.Quantities", "Make_MakeId");
            CreateIndex("dbo.VendorWarehouses", "Vendor_VendorId");
            CreateIndex("dbo.Assets", "Vendor_VendorId");
            CreateIndex("dbo.Assets", "Type_TypeId");
            CreateIndex("dbo.Assets", "Model_ModelId");
            CreateIndex("dbo.Assets", "Make_MakeId");
            CreateIndex("dbo.Assets", "Category_CategoryId");
            AddForeignKey("dbo.Quantities", "Vendor_VendorId", "dbo.Vendors", "VendorId");
            AddForeignKey("dbo.Quantities", "Model_ModelId", "dbo.Models", "ModelId");
            AddForeignKey("dbo.Quantities", "Make_MakeId", "dbo.Makes", "MakeId");
            AddForeignKey("dbo.VendorWarehouses", "Vendor_VendorId", "dbo.Vendors", "VendorId");
            AddForeignKey("dbo.Assets", "Vendor_VendorId", "dbo.Vendors", "VendorId");
            AddForeignKey("dbo.Assets", "Type_TypeId", "dbo.Types", "TypeId");
            AddForeignKey("dbo.Assets", "Model_ModelId", "dbo.Models", "ModelId");
            AddForeignKey("dbo.Assets", "Make_MakeId", "dbo.Makes", "MakeId");
            AddForeignKey("dbo.Assets", "Category_CategoryId", "dbo.Categories", "CategoryId");
        }
    }
}
