namespace NAControl.Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _23102017_MEETING : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MeeMeeting", "Mee_GrouId", "dbo.GroGroup");
            AddForeignKey("dbo.MeeMeeting", "Mee_GrouId", "dbo.GroGroup", "GroId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MeeMeeting", "Mee_GrouId", "dbo.GroGroup");
            AddForeignKey("dbo.MeeMeeting", "Mee_GrouId", "dbo.GroGroup", "GroId");
        }
    }
}
