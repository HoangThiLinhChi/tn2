namespace PMQLKSCK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creata_Table_NhanViens : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        Ma_Nv = c.String(nullable: false, maxLength: 128),
                        Ho_Nv = c.String(),
                        Ten_Nv = c.String(),
                        ChucVu = c.String(),
                        SoCMT = c.String(),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.Ma_Nv);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhanViens");
        }
    }
}
