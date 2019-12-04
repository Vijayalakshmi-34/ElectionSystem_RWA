namespace ElectionSystem_RWA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creatingdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Postings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Post = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Qualifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QualificationType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Qualifications");
            DropTable("dbo.Postings");
        }
    }
}
