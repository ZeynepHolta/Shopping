namespace eCommerce.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShoppingDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        ShoppingCardId = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false, storeType: "date"),
                        Quantity = c.Int(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.ShoppingCard", t => t.ShoppingCardId, cascadeDelete: true)
                .Index(t => t.ShoppingCardId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 50),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Order_OrderId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Order", t => t.Order_OrderId)
                .Index(t => t.Order_OrderId);
            
            CreateTable(
                "dbo.ShoppingCard",
                c => new
                    {
                        ShoppingCardId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ShoppingCardId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 16),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.ShoppingCardProductDetails",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        ShoppingCardId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.ShoppingCardId })
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.ShoppingCard", t => t.ShoppingCardId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.ShoppingCardId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Order", "ShoppingCardId", "dbo.ShoppingCard");
            DropForeignKey("dbo.Product", "Order_OrderId", "dbo.Order");
            DropForeignKey("dbo.ShoppingCardProductDetails", "ShoppingCardId", "dbo.ShoppingCard");
            DropForeignKey("dbo.ShoppingCardProductDetails", "ProductId", "dbo.Product");
            DropIndex("dbo.ShoppingCardProductDetails", new[] { "ShoppingCardId" });
            DropIndex("dbo.ShoppingCardProductDetails", new[] { "ProductId" });
            DropIndex("dbo.Product", new[] { "Order_OrderId" });
            DropIndex("dbo.Order", new[] { "ShoppingCardId" });
            DropTable("dbo.ShoppingCardProductDetails");
            DropTable("dbo.User");
            DropTable("dbo.ShoppingCard");
            DropTable("dbo.Product");
            DropTable("dbo.Order");
        }
    }
}
