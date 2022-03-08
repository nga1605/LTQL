namespace NTNBaiThucHanh801.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hiih : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Persons",
                c => new
                    {
                        personID = c.String(nullable: false, maxLength: 128),
                        personName = c.String(),
                    })
                .PrimaryKey(t => t.personID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Persons");
        }
    }
}
