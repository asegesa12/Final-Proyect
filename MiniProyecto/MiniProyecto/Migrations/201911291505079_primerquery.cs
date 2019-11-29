namespace MiniProyecto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primerquery : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cargoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departamentoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        codigo = c.Int(nullable: false),
                        Nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Empleados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Nombre = c.String(nullable: false),
                        Apellido = c.String(nullable: false),
                        Telefono = c.String(nullable: false),
                        Departamento = c.String(nullable: false),
                        Cargo = c.String(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Salario = c.Int(nullable: false),
                        Estatus = c.String(nullable: false),
                        Crg_Id = c.Int(),
                        dpto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cargoes", t => t.Crg_Id)
                .ForeignKey("dbo.Departamentoes", t => t.dpto_Id)
                .Index(t => t.Crg_Id)
                .Index(t => t.dpto_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empleados", "dpto_Id", "dbo.Departamentoes");
            DropForeignKey("dbo.Empleados", "Crg_Id", "dbo.Cargoes");
            DropIndex("dbo.Empleados", new[] { "dpto_Id" });
            DropIndex("dbo.Empleados", new[] { "Crg_Id" });
            DropTable("dbo.Empleados");
            DropTable("dbo.Departamentoes");
            DropTable("dbo.Cargoes");
        }
    }
}
