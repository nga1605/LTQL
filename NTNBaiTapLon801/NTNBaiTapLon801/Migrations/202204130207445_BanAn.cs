namespace NTNBaiTapLon801.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BanAn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BanAns",
                c => new
                    {
                        BanAnID = c.String(nullable: false, maxLength: 128),
                        TrangthaiBanAn = c.String(),
                        DanhsachBanAn = c.String(),
                    })
                .PrimaryKey(t => t.BanAnID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BanAns");
        }
    }
}
