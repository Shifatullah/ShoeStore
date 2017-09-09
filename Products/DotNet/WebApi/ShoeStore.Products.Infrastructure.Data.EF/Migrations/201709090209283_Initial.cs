namespace ShoeStore.Products.Infrastructure.Data.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "ssp.Assets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedOn = c.DateTimeOffset(nullable: false, precision: 7),
                        CreatedBy = c.String(nullable: false),
                        ModifiedOn = c.DateTimeOffset(precision: 7),
                        ModifiedBy = c.String(),
                        DeletedOn = c.DateTimeOffset(precision: 7),
                        DeletedBy = c.String(),
                        AssetId = c.Int(),
                        Size = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ssp.Catalogues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        State = c.Int(nullable: false),
                        PublishedOn = c.DateTime(nullable: false),
                        CreatedOn = c.DateTimeOffset(nullable: false, precision: 7),
                        CreatedBy = c.String(nullable: false),
                        ModifiedOn = c.DateTimeOffset(precision: 7),
                        ModifiedBy = c.String(),
                        DeletedOn = c.DateTimeOffset(precision: 7),
                        DeletedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ssp.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Slug = c.String(),
                        ParentCategoryId = c.Int(nullable: false),
                        Rank = c.Int(nullable: false),
                        CreatedOn = c.DateTimeOffset(nullable: false, precision: 7),
                        CreatedBy = c.String(nullable: false),
                        ModifiedOn = c.DateTimeOffset(precision: 7),
                        ModifiedBy = c.String(),
                        DeletedOn = c.DateTimeOffset(precision: 7),
                        DeletedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ssp.Categories", t => t.ParentCategoryId)
                .Index(t => t.ParentCategoryId);
            
            CreateTable(
                "ssp.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Rank = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        Cost = c.Decimal(precision: 18, scale: 2),
                        Stock = c.Int(),
                        CategoryId = c.Int(),
                        CreatedOn = c.DateTimeOffset(nullable: false, precision: 7),
                        CreatedBy = c.String(nullable: false),
                        ModifiedOn = c.DateTimeOffset(precision: 7),
                        ModifiedBy = c.String(),
                        DeletedOn = c.DateTimeOffset(precision: 7),
                        DeletedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ssp.ProductAssets",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        AssetId = c.Int(nullable: false),
                        Name = c.String(),
                        AssetType = c.Int(nullable: false),
                        CreatedOn = c.DateTimeOffset(nullable: false, precision: 7),
                        CreatedBy = c.String(nullable: false),
                        ModifiedOn = c.DateTimeOffset(precision: 7),
                        ModifiedBy = c.String(),
                        DeletedOn = c.DateTimeOffset(precision: 7),
                        DeletedBy = c.String(),
                    })
                .PrimaryKey(t => new { t.ProductId, t.AssetId })
                .ForeignKey("ssp.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "ssp.ProductPrices",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("ssp.Products", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("ssp.ProductPrices", "Product_Id", "ssp.Products");
            DropForeignKey("ssp.ProductAssets", "ProductId", "ssp.Products");
            DropForeignKey("ssp.Categories", "ParentCategoryId", "ssp.Categories");
            DropIndex("ssp.ProductPrices", new[] { "Product_Id" });
            DropIndex("ssp.ProductAssets", new[] { "ProductId" });
            DropIndex("ssp.Categories", new[] { "ParentCategoryId" });
            DropTable("ssp.ProductPrices");
            DropTable("ssp.ProductAssets");
            DropTable("ssp.Products");
            DropTable("ssp.Categories");
            DropTable("ssp.Catalogues");
            DropTable("ssp.Assets");
        }
    }
}
