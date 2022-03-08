namespace NTNBaiThucHanh801.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hihi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.students",
                c => new
                    {
                        studentID = c.String(nullable: false, maxLength: 128),
                        studentName = c.String(),
                    })
                .PrimaryKey(t => t.studentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.students");
        }
    }
}
