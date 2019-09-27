namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreFinal : DbMigration
    {
        public override void Up()
        {
            Sql("insert into dbo.Genres(name) values ('Comedy')");
            Sql("insert into dbo.Genres(name) values ('Action')");
            Sql("insert into dbo.Genres(name) values ('Family')");
            Sql("insert into dbo.Genres(name) values ('Romance')");
            Sql("drop table dbo.Genre");
        }
        
        public override void Down()
        {
        }
    }
}
