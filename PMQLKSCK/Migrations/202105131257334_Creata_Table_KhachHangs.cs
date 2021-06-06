namespace PMQLKSCK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creata_Table_KhachHangs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        Ma_Kh = c.String(nullable: false, maxLength: 128),
                        Ho_Kh = c.String(),
                        Ten_Kh = c.String(),
                        SoCMT = c.String(),
                        SĐT = c.String(),
                    })
                .PrimaryKey(t => t.Ma_Kh);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KhachHangs");
        }
    }
}
