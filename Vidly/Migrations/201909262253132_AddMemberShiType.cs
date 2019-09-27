namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShiType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        id = c.Byte(nullable: false),
                        signUpFee = c.Short(nullable: false),
                        durationInMonths = c.Byte(nullable: false),
                        discountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Customers", "memberShipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "memberShipTypeId");
            AddForeignKey("dbo.Customers", "memberShipTypeId", "dbo.MembershipTypes", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "memberShipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "memberShipTypeId" });
            DropColumn("dbo.Customers", "memberShipTypeId");
            DropTable("dbo.MembershipTypes");
        }
    }
}
