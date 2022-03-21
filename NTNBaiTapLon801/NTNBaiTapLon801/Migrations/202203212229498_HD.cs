namespace NTNBaiTapLon801.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        TenMonAn = c.String(nullable: false, maxLength: 128),
                        GiaTien = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TenMonAn);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HoaDons");
        }
    }
}
