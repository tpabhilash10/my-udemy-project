namespace VandanamVillas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCDateColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bookings", "CDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bookings", "CDate");
        }
    }
}
