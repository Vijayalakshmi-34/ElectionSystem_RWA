namespace ElectionSystem_RWA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Presidents", "Vote", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Presidents", "Vote");
        }
    }
}
