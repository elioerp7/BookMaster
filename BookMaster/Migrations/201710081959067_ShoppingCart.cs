namespace BookMaster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShoppingCart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cart",
                c => new
                {
                    RecordId = c.Int(nullable: false),
                    CartId = c.String(),
                    BookId = c.String(),
                    Count = c.Int(),
                    DateCreated = c.DateTime()
                })
                .PrimaryKey(t => t.RecordId);
            CreateTable(
                "dbo.Order",
                c => new
                {
                    OrderId = c.Int(nullable: false),
                    Username = c.String(),
                    FristName = c.String(),
                    LastName = c.String(),
                    Adrress = c.String(),
                    City = c.String(),
                    State = c.String(),
                    PostalCode = c.String(),
                    Country = c.String(),
                    Phone = c.String(),
                    Email = c.String(),
                    Total = c.String(),
                    OrderDate = c.DateTime()
                })
                .PrimaryKey(t => t.OrderId);
            CreateTable(
                "dbo.OrderDetail",
                c => new
                {
                    OrderDetailId = c.Int(nullable: false),
                    OrderId = c.Int(),
                    BookId = c.Int(),
                    Quantity = c.Int(),
                    UnitPrice = c.Double()
                })
                .PrimaryKey(t => t.OrderDetailId);
        }

        public override void Down()
        {
            DropTable("dbo.Cart");
            DropTable("dbo.Order");
            DropTable("dbo.OrderDetail");
        }
    }
}
