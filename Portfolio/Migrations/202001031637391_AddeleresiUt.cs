namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddeleresiUt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Munkaims", "eleresiUt", c => c.String());
            Sql("UPDATE Munkaims SET eleresiUt='Abstrakt Cube.mp4' WHERE Id=1");
            Sql("UPDATE Munkaims SET eleresiUt='Area Attack.mp4' WHERE Id=2");
            Sql("UPDATE Munkaims SET eleresiUt='Camp Fire.mp4' WHERE Id=3");
            Sql("UPDATE Munkaims SET eleresiUt='Curl Noise.mp4' WHERE Id=4");
            Sql("UPDATE Munkaims SET eleresiUt='Dragon Breath.mp4' WHERE Id=5");
            Sql("UPDATE Munkaims SET eleresiUt='Explosion.mp4' WHERE Id=6");
            Sql("UPDATE Munkaims SET eleresiUt='Fire Lake.mp4' WHERE Id=7");
            Sql("UPDATE Munkaims SET eleresiUt='Ground Collapse.mp4' WHERE Id=8");
            Sql("UPDATE Munkaims SET eleresiUt='House Destruction.mp4' WHERE Id=9");
            Sql("UPDATE Munkaims SET eleresiUt='Moon Destruction.mp4' WHERE Id=10");
            Sql("UPDATE Munkaims SET eleresiUt='Scifi Shield.mp4' WHERE Id=11");
            Sql("UPDATE Munkaims SET eleresiUt='Ship in Bottle.mp4' WHERE Id=12");
            Sql("UPDATE Munkaims SET eleresiUt='Skull Droplets.mp4' WHERE Id=13");
            Sql("UPDATE Munkaims SET eleresiUt='Superhero Landing.mp4' WHERE Id=14");
            Sql("UPDATE Munkaims SET eleresiUt='Thanos Portal.mp4' WHERE Id=15");
            Sql("UPDATE Munkaims SET eleresiUt='The First Meet.mp4' WHERE Id=16");
            Sql("UPDATE Munkaims SET eleresiUt='Waking Up.mp4' WHERE Id=17");             
        }
        
        public override void Down()
        {
            DropColumn("dbo.Munkaims", "eleresiUt");
        }
    }
}
