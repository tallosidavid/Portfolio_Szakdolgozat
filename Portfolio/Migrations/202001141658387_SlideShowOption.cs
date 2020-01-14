namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SlideShowOption : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Munkaims", "SlideShow", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Munkaims", "SlideShow");
        }
    }
}
