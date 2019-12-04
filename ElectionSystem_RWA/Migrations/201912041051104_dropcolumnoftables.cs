namespace ElectionSystem_RWA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropcolumnoftables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Members", "PostingId", "dbo.Postings");
            DropForeignKey("dbo.Secretaries", "PostingId", "dbo.Postings");
            DropForeignKey("dbo.Treasurers", "PostingId", "dbo.Postings");
            DropForeignKey("dbo.VicePresidents", "PostingId", "dbo.Postings");
            DropIndex("dbo.Members", new[] { "PostingId" });
            DropIndex("dbo.Secretaries", new[] { "PostingId" });
            DropIndex("dbo.Treasurers", new[] { "PostingId" });
            DropIndex("dbo.VicePresidents", new[] { "PostingId" });
            DropColumn("dbo.Members", "PostingId");
            DropColumn("dbo.Secretaries", "PostingId");
            DropColumn("dbo.Treasurers", "PostingId");
            DropColumn("dbo.VicePresidents", "PostingId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VicePresidents", "PostingId", c => c.Int(nullable: false));
            AddColumn("dbo.Treasurers", "PostingId", c => c.Int(nullable: false));
            AddColumn("dbo.Secretaries", "PostingId", c => c.Int(nullable: false));
            AddColumn("dbo.Members", "PostingId", c => c.Int(nullable: false));
            CreateIndex("dbo.VicePresidents", "PostingId");
            CreateIndex("dbo.Treasurers", "PostingId");
            CreateIndex("dbo.Secretaries", "PostingId");
            CreateIndex("dbo.Members", "PostingId");
            AddForeignKey("dbo.VicePresidents", "PostingId", "dbo.Postings", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Treasurers", "PostingId", "dbo.Postings", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Secretaries", "PostingId", "dbo.Postings", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Members", "PostingId", "dbo.Postings", "Id", cascadeDelete: true);
        }
    }
}
