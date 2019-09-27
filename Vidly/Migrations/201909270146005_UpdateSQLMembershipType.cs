namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSQLMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("Update [MembershipTypes] set membershipName = 'Pay as you Go' where id= 1");
            Sql("Update [MembershipTypes] set membershipName = 'Monthly' where id= 2");
            Sql("Update [MembershipTypes] set membershipName = 'Quarterly' where id= 3");
            Sql("Update [MembershipTypes] set membershipName = 'Yearly' where id= 4");
        }
        
        public override void Down()
        {
        }
    }
}
