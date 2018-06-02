namespace SistemaControlAeroeste2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class matricula : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matricula",
                c => new
                    {
                        id = c.Int(nullable: false),
                        matricula = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Matricula");
        }
    }
}
