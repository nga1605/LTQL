namespace NTNBaiTapLon801.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MA : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MonAns",
                c => new
                    {
                        TenMonAn = c.String(nullable: false, maxLength: 128),
                        SoLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TenMonAn);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MonAns");
        }
    }
}
