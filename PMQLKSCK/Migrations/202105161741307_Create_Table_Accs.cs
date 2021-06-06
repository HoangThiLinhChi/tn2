namespace PMQLKSCK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Accs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accs",
                c => new
                    {
                        IDacc = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.IDacc);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Accs");
        }
    }
}
