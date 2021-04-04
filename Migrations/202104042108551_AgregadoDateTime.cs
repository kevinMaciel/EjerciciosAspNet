namespace Vuelos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregadoDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vuelos", "HorarioLlegada", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vuelos", "HorarioLlegada", c => c.String(nullable: false));
        }
    }
}
