namespace PMQLKSCK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creata_Table_DichVus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DichVus",
                c => new
                    {
                        Ma_Dv = c.String(nullable: false, maxLength: 128),
                        Ten_Dv = c.String(),
                        Gia = c.String(),
                    })
                .PrimaryKey(t => t.Ma_Dv);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DichVus");
        }
    }
}
