namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "releaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "dateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "numberInStock", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "name", c => c.String(nullable: false));
            //Sql("insert into dbo.Genre(id,name) values (1, 'Comedy')");
           
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "name", c => c.String());
            DropColumn("dbo.Movies", "numberInStock");
            DropColumn("dbo.Movies", "dateAdded");
            DropColumn("dbo.Movies", "releaseDate");
        }
    }
}
