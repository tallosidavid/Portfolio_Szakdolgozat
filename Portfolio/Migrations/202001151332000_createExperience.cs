namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createExperience : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Hol = c.String(nullable: false),
                        Mit = c.String(nullable: false),
                        Aktiv = c.Boolean(nullable: false),
                        Mettol = c.DateTime(nullable: false),
                        Meddig = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Experiences");
        }
    }
}
