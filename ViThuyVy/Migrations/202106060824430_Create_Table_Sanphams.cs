namespace ViThuyVy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Sanphams : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sanphams",
                c => new
                    {
                        Masanpham = c.String(nullable: false, maxLength: 128),
                        TenSanPham = c.String(),
                        MaNhaCungCap = c.String(),
                    })
                .PrimaryKey(t => t.Masanpham);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sanphams");
        }
    }
}
