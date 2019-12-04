namespace ElectionSystem_RWA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createvotertable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Voters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        President = c.String(),
                        VicePresident = c.String(),
                        Secretary = c.String(),
                        Treasure = c.String(),
                        Member1 = c.String(),
                        Member2 = c.String(),
                        Member3 = c.String(),
                        Member4 = c.String(),
                        Member5 = c.String(),
                        Member6 = c.String(),
                        UnitId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Units", t => t.UnitId, cascadeDelete: true)
                .Index(t => t.UnitId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Voters", "UnitId", "dbo.Units");
            DropIndex("dbo.Voters", new[] { "UnitId" });
            DropTable("dbo.Voters");
        }
    }
}
