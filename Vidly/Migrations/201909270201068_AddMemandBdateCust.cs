namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemandBdateCust : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "membershipName", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "membershipName", c => c.String());
        }
    }
}
