namespace NTNBaiTapLon801.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QLBA : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.QLBanAns");
            AddColumn("dbo.QLBanAns", "SoBan", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.QLBanAns", "TrangthaiBanAn", c => c.String());
            AddPrimaryKey("dbo.QLBanAns", "SoBan");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.QLBanAns");
            AlterColumn("dbo.QLBanAns", "TrangthaiBanAn", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.QLBanAns", "SoBan");
            AddPrimaryKey("dbo.QLBanAns", "TrangthaiBanAn");
        }
    }
}
