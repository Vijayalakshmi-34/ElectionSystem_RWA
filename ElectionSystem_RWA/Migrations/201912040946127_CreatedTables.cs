namespace ElectionSystem_RWA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CandidateName = c.String(),
                        CurrentOccupation = c.String(),
                        PreviousRWAMember = c.String(),
                        PartOfGovtPoliceNGO = c.String(),
                        CriminalRecord = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        QualificationId = c.Int(nullable: false),
                        PostingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Postings", t => t.PostingId, cascadeDelete: true)
                .ForeignKey("dbo.Qualifications", t => t.QualificationId, cascadeDelete: true)
                .Index(t => t.QualificationId)
                .Index(t => t.PostingId);
            
            CreateTable(
                "dbo.Presidents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CandidateName = c.String(),
                        CurrentOccupation = c.String(),
                        PreviousRWAMember = c.String(),
                        PartOfGovtPoliceNGO = c.String(),
                        CriminalRecord = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        QualificationId = c.Int(nullable: false),
                        PostingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Postings", t => t.PostingId, cascadeDelete: true)
                .ForeignKey("dbo.Qualifications", t => t.QualificationId, cascadeDelete: true)
                .Index(t => t.QualificationId)
                .Index(t => t.PostingId);
            
            CreateTable(
                "dbo.Secretaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CandidateName = c.String(),
                        CurrentOccupation = c.String(),
                        PreviousRWAMember = c.String(),
                        PartOfGovtPoliceNGO = c.String(),
                        CriminalRecord = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        QualificationId = c.Int(nullable: false),
                        PostingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Postings", t => t.PostingId, cascadeDelete: true)
                .ForeignKey("dbo.Qualifications", t => t.QualificationId, cascadeDelete: true)
                .Index(t => t.QualificationId)
                .Index(t => t.PostingId);
            
            CreateTable(
                "dbo.Treasurers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CandidateName = c.String(),
                        CurrentOccupation = c.String(),
                        PreviousRWAMember = c.String(),
                        PartOfGovtPoliceNGO = c.String(),
                        CriminalRecord = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        QualificationId = c.Int(nullable: false),
                        PostingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Postings", t => t.PostingId, cascadeDelete: true)
                .ForeignKey("dbo.Qualifications", t => t.QualificationId, cascadeDelete: true)
                .Index(t => t.QualificationId)
                .Index(t => t.PostingId);
            
            CreateTable(
                "dbo.VicePresidents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CandidateName = c.String(),
                        CurrentOccupation = c.String(),
                        PreviousRWAMember = c.String(),
                        PartOfGovtPoliceNGO = c.String(),
                        CriminalRecord = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        QualificationId = c.Int(nullable: false),
                        PostingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Postings", t => t.PostingId, cascadeDelete: true)
                .ForeignKey("dbo.Qualifications", t => t.QualificationId, cascadeDelete: true)
                .Index(t => t.QualificationId)
                .Index(t => t.PostingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VicePresidents", "QualificationId", "dbo.Qualifications");
            DropForeignKey("dbo.VicePresidents", "PostingId", "dbo.Postings");
            DropForeignKey("dbo.Treasurers", "QualificationId", "dbo.Qualifications");
            DropForeignKey("dbo.Treasurers", "PostingId", "dbo.Postings");
            DropForeignKey("dbo.Secretaries", "QualificationId", "dbo.Qualifications");
            DropForeignKey("dbo.Secretaries", "PostingId", "dbo.Postings");
            DropForeignKey("dbo.Presidents", "QualificationId", "dbo.Qualifications");
            DropForeignKey("dbo.Presidents", "PostingId", "dbo.Postings");
            DropForeignKey("dbo.Members", "QualificationId", "dbo.Qualifications");
            DropForeignKey("dbo.Members", "PostingId", "dbo.Postings");
            DropIndex("dbo.VicePresidents", new[] { "PostingId" });
            DropIndex("dbo.VicePresidents", new[] { "QualificationId" });
            DropIndex("dbo.Treasurers", new[] { "PostingId" });
            DropIndex("dbo.Treasurers", new[] { "QualificationId" });
            DropIndex("dbo.Secretaries", new[] { "PostingId" });
            DropIndex("dbo.Secretaries", new[] { "QualificationId" });
            DropIndex("dbo.Presidents", new[] { "PostingId" });
            DropIndex("dbo.Presidents", new[] { "QualificationId" });
            DropIndex("dbo.Members", new[] { "PostingId" });
            DropIndex("dbo.Members", new[] { "QualificationId" });
            DropTable("dbo.VicePresidents");
            DropTable("dbo.Treasurers");
            DropTable("dbo.Secretaries");
            DropTable("dbo.Presidents");
            DropTable("dbo.Members");
        }
    }
}
