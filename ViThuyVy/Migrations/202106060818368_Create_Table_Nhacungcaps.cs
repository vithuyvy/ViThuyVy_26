namespace ViThuyVy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Nhacungcaps : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nhacungcaps",
                c => new
                    {
                        MaNhaCungCap = c.String(nullable: false, maxLength: 128),
                        TenNhaCungCap = c.String(),
                    })
                .PrimaryKey(t => t.MaNhaCungCap);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Nhacungcaps");
        }
    }
}
