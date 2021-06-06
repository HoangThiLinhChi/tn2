namespace PMQLKSCK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creata_Table_HoaDons : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        Ma_HD = c.String(nullable: false, maxLength: 128),
                        Ten_HD = c.String(),
                        NgayTT = c.String(),
                        ThanhTien = c.String(),
                        Ma_Kh = c.String(),
                    })
                .PrimaryKey(t => t.Ma_HD);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HoaDons");
        }
    }
}
