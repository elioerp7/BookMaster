namespace BookMaster.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class dataPop : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Books (ISBN, Title, Description, Price, Author, Genre, Publisher) " +
                "values ('978-0553593716', 'A Game of Thrones (A Song of Ice and Fire, Book 1)', " +
                "'Description1', 40.30, 'George R. Martin', 'Fantasy', 'Bantam' )");

            Sql("insert into Books (ISBN, Title, Description, Price, Author, Genre, Publisher) " +
                "values ('978-1455582877', 'The Notebook', 'Description2', 20.50, 'Nicholas Sparks','Romance', 'Grand Central Publishing')");

        }
        
        public override void Down()
        {
            Sql("delete * from Books");
        }
    }
}
