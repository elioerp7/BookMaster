namespace BookMaster.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[Books] ([ISBN], [Title], [Description], [Price], [Author], [Genre], [Publisher], [Quantity], [image], [isFeatured]) VALUES (N'978-0062315007', N'The Alchemist', N'Description7', 34.99, N'Paulo Coelho', N'Adventure', N'HarperOne', 60, N'516c6gUQLaL._SX329_BO1,204,203,200_.jpg', 1)");
            Sql("INSERT INTO [dbo].[Books] ([ISBN], [Title], [Description], [Price], [Author], [Genre], [Publisher], [Quantity], [image], [isFeatured]) VALUES (N'978-0156012195', N'The Little Prince', N'Description4', 7.99, N'Antoine de Saint-Exupéry', N'Adventure', N'Mariner Books', 70, N'51dEm+C0EXL._SX340_BO1,204,203,200_.jpg', 1)");

        }

        public override void Down()
        {

            Sql("Drop * from [dbo].[Books]");
        }
    }
}
