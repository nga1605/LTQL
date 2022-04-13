namespace NTNBaiTapLon801.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MonAn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MonAns",
                c => new
                    {
                        MonAnID = c.String(nullable: false, maxLength: 128),
                        TenMonAn = c.String(),
                        SoLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MonAnID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MonAns");
        }
    }
}
