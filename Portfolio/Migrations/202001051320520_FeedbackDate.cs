namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FeedbackDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Feedbacks", "HozzaadasDatuma", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Feedbacks", "HozzaadasDatuma");
        }
    }
}
