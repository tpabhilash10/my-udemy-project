namespace VandanamVillas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAppConfig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppConfigs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmailSMTP = c.String(),
                        EmailSMTPUsername = c.String(),
                        EmailSMTPPassword = c.String(),
                        EmailFromID = c.String(),
                        EmailToID = c.String(),
                        EmailCCTo = c.String(),
                        EmailBCCTo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AppConfigs");
        }
    }
}
