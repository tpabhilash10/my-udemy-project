namespace VandanamVillas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetDefaultCDateVal : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Bookings", "CDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bookings", "CDate", c => c.DateTime(nullable: false));
        }
    }
}
