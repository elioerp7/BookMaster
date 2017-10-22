namespace BookMaster.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class dataPop : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Books (`ISBN`, `Title`, `Description`, `Price`, `Author`,`Genre`, `Publisher`, `Quantity`, `image`, `isFeatured`) VALUES (N'978-0062315007', N'The Alchemist', N'Description7', 34.99, N'Paulo Coelho', N'Adventure', N'HarperOne', 60, N'http://t2.gstatic.com/images?q=tbn:ANd9GcTAyMeaePHdaWi1UppB8qvu2GtO4jfpufEsS3cR8Sp9Is-x3KXb', 1");

            Sql("INSERT INTO Books (`ISBN`, `Title`, `Description`, `Price`, `Author`, `Genre`, `Publisher`, `Quantity`, `image`, `isFeatured`) VALUES (N'978-0156012195', N'The Little Prince', N'Description4', 7.99, N'Antoine de Saint-Exupéry', N'Adventure', N'Mariner Books', 70, N'https://books.google.com/books/content/images/frontcover/NhTyjt0V9tsC?fife=w300-rw', 1)");

        }
        
        public override void Down()
        {
            Sql("truncate table Books");
        }
    }
}
