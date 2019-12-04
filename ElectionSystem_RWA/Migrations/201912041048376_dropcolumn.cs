namespace ElectionSystem_RWA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropcolumn : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Presidents", "PostingId", "dbo.Postings");
            DropIndex("dbo.Presidents", new[] { "PostingId" });
            DropColumn("dbo.Presidents", "PostingId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Presidents", "PostingId", c => c.Int(nullable: false));
            CreateIndex("dbo.Presidents", "PostingId");
            AddForeignKey("dbo.Presidents", "PostingId", "dbo.Postings", "Id", cascadeDelete: true);
        }
    }
}
