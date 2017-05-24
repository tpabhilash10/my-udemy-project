namespace VandanamVillas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingMobileTypeToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bookings", "Mobile", c => c.String(nullable: false, maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bookings", "Mobile", c => c.Int(nullable: false));
        }
    }
}
