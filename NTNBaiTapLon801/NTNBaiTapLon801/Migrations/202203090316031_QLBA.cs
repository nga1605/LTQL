namespace NTNBaiTapLon801.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QLBA : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QLBanAns",
                c => new
                    {
                        TrangthaiBanAn = c.String(nullable: false, maxLength: 128),
                        DanhsachBanAn = c.String(),
                    })
                .PrimaryKey(t => t.TrangthaiBanAn);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.QLBanAns");
        }
    }
}
