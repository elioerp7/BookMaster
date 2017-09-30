namespace BookMaster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class image : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "image", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "image");
        }
    }
}
