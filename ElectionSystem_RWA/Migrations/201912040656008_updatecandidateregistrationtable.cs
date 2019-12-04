namespace ElectionSystem_RWA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatecandidateregistrationtable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CandidateRegistrations", "CandidateName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CandidateRegistrations", "CandidateName");
        }
    }
}
