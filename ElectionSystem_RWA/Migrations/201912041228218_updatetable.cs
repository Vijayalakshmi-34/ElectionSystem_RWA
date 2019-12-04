namespace ElectionSystem_RWA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Presidents", "Vote");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Presidents", "Vote", c => c.Boolean(nullable: false));
        }
    }
}
