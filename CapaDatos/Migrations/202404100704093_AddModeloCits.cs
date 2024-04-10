namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModeloCits : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MCitas",
                c => new
                    {
                        CitaId = c.Int(nullable: false, identity: true),
                        MedicoId = c.Int(nullable: false),
                        PacienteId = c.Int(nullable: false),
                        FechaICita = c.DateTime(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CitaId)
                .ForeignKey("dbo.MMedicos", t => t.MedicoId)
                .ForeignKey("dbo.MPacientes", t => t.PacienteId)
                .Index(t => t.MedicoId)
                .Index(t => t.PacienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MCitas", "PacienteId", "dbo.MPacientes");
            DropForeignKey("dbo.MCitas", "MedicoId", "dbo.MMedicos");
            DropIndex("dbo.MCitas", new[] { "PacienteId" });
            DropIndex("dbo.MCitas", new[] { "MedicoId" });
            DropTable("dbo.MCitas");
        }
    }
}
