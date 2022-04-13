namespace NTNBaiTapLon801.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BanAn : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.BanAns");
            AlterColumn("dbo.BanAns", "BanAnID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.BanAns", "BanAnID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.BanAns");
            AlterColumn("dbo.BanAns", "BanAnID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.BanAns", "BanAnID");
        }
    }
}
