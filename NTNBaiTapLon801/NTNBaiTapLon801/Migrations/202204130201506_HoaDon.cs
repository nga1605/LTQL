namespace NTNBaiTapLon801.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HoaDon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        HoaDonID = c.String(nullable: false, maxLength: 128),
                        TenMonAn = c.String(),
                        GiaTien = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HoaDonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HoaDons");
        }
    }
}
