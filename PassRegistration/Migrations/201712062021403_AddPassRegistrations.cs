namespace PassRegistration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPassRegistrations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PassRegistrations", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PassRegistrations", "Status");
        }
    }
}
