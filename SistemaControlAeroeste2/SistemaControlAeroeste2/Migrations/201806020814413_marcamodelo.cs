namespace SistemaControlAeroeste2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class marcamodelo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MarcaModelo",
                c => new
                    {
                        id = c.Int(nullable: false),
                        idMarca = c.Int(nullable: false),
                        idModelo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MarcaModelo");
        }
    }
}
