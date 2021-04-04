namespace Vuelos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregadoValidaciones2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vuelos", "NumVuelo", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vuelos", "NumVuelo", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
