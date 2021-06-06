namespace PMQLKSCK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creata_Table_Phongs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Phongs",
                c => new
                    {
                        MaPhong = c.String(nullable: false, maxLength: 128, fixedLength: true, unicode: false),
                        TenPhong = c.String(),
                        GiaPhong = c.String(),
                        LoaiPhong = c.String(),
                    })
                .PrimaryKey(t => t.MaPhong);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Phongs");
        }
    }
}
