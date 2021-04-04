namespace Vuelos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregadoValidaciones : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vuelos", "NumVuelo", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Vuelos", "HorarioLlegada", c => c.String(nullable: false));
            AlterColumn("dbo.Vuelos", "LineaArea", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vuelos", "LineaArea", c => c.String());
            AlterColumn("dbo.Vuelos", "HorarioLlegada", c => c.String());
            AlterColumn("dbo.Vuelos", "NumVuelo", c => c.String());
        }
    }
}
