namespace VandanamVillas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAppConfigColumnlength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AppConfigs", "EmailFromID", c => c.String(maxLength: 50));
            AlterColumn("dbo.AppConfigs", "EmailToID", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AppConfigs", "EmailToID", c => c.String(maxLength: 20));
            AlterColumn("dbo.AppConfigs", "EmailFromID", c => c.String(maxLength: 20));
        }
    }
}
