namespace PassRegistration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testmig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PassRegistrations", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.PassRegistrations", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.PassRegistrations", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PassRegistrations", "Email", c => c.String());
            AlterColumn("dbo.PassRegistrations", "PhoneNumber", c => c.String());
            AlterColumn("dbo.PassRegistrations", "Name", c => c.String());
        }
    }
}
