namespace SistemaControlAeroeste2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aeronave : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aeronave",
                c => new
                    {
                        id = c.Int(nullable: false),
                        idMarcaModelo = c.Int(nullable: false),
                        idMatricula = c.Int(nullable: false),
                        serie = c.String(),
                        att = c.Double(nullable: false),
                        atc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Aeronave");
        }
    }
}
