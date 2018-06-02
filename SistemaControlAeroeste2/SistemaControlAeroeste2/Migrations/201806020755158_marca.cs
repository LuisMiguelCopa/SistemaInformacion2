namespace SistemaControlAeroeste2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class marca : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        id = c.Int(nullable: false),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Marca");
        }
    }
}
