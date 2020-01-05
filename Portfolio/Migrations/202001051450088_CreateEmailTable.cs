namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEmailTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Felado = c.String(nullable: false),
                        EmailCim = c.String(nullable: false),
                        Uzenet = c.String(nullable: false),
                        Idopont = c.DateTime(nullable: false),
                        Lattamozott = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Emails");
        }
    }
}
