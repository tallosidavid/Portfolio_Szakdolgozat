namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Works : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Munkaims", "Cim", c => c.String(nullable: false));
            AlterColumn("dbo.Munkaims", "Leiras", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Munkaims", "Leiras", c => c.String());
            AlterColumn("dbo.Munkaims", "Cim", c => c.String());
        }
    }
}
