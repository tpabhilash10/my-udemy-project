namespace VandanamVillas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAppConfigColumnAgain : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AppConfigs", "EmailSMTPUsername", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AppConfigs", "EmailSMTPUsername", c => c.String(maxLength: 20));
        }
    }
}
