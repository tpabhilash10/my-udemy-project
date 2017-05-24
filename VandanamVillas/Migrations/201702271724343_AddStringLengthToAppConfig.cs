namespace VandanamVillas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStringLengthToAppConfig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AppConfigs", "EmailSMTP", c => c.String(maxLength: 20));
            AlterColumn("dbo.AppConfigs", "EmailSMTPUsername", c => c.String(maxLength: 20));
            AlterColumn("dbo.AppConfigs", "EmailSMTPPassword", c => c.String(maxLength: 20));
            AlterColumn("dbo.AppConfigs", "EmailFromID", c => c.String(maxLength: 20));
            AlterColumn("dbo.AppConfigs", "EmailToID", c => c.String(maxLength: 20));
            AlterColumn("dbo.AppConfigs", "EmailCCTo", c => c.String(maxLength: 200));
            AlterColumn("dbo.AppConfigs", "EmailBCCTo", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AppConfigs", "EmailBCCTo", c => c.String());
            AlterColumn("dbo.AppConfigs", "EmailCCTo", c => c.String());
            AlterColumn("dbo.AppConfigs", "EmailToID", c => c.String());
            AlterColumn("dbo.AppConfigs", "EmailFromID", c => c.String());
            AlterColumn("dbo.AppConfigs", "EmailSMTPPassword", c => c.String());
            AlterColumn("dbo.AppConfigs", "EmailSMTPUsername", c => c.String());
            AlterColumn("dbo.AppConfigs", "EmailSMTP", c => c.String());
        }
    }
}
