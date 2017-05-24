namespace VandanamVillas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAppConfig : DbMigration
    {
        public override void Up()
        {
            Sql("insert into AppConfigs (EmailSMTP, EmailSMTPUsername, EmailSMTPPassword, EmailFromID, EmailToID, EmailCCTo, EmailBCCTo) values ('103.21.59.175','info@vandanamvillas.in','adminv@143','info@vandanamvillas.in','info@vandanamvillas.in','','atp1981@gmail.com!santosh719@gmail.com')");
        }
        
        public override void Down()
        {
        }
    }
}
