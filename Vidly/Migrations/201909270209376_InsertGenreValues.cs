namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertGenreValues : DbMigration
    {
        public override void Up()
        {
            //Sql("insert into dbo.Genre values (1, 'Comedy')");
            //Sql("insert into dbo.Genre values (2, 'Action')");
            //Sql("insert into dbo.Genre values (3, 'Family')");
            //Sql("insert into dbo.Genre values (4, 'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
