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
            Sql("UPDATE Munkaims SET eleresiUt='nevtelenJatekIntro.mp4' WHERE Id=18");             
            Sql("UPDATE Munkaims SET eleresiUt='Cohaire_Arms.png' WHERE Id=19");             
            Sql("UPDATE Munkaims SET eleresiUt='DTA_Stealth_Sniper.png' WHERE Id=20");             
            Sql("UPDATE Munkaims SET eleresiUt='HK416D.png' WHERE Id=21");             
            Sql("UPDATE Munkaims SET eleresiUt='Hotel_DONE_Light.png' WHERE Id=22");             
            Sql("UPDATE Munkaims SET eleresiUt='IWI_Tavor.png' WHERE Id=23");             
            Sql("UPDATE Munkaims SET eleresiUt='John_Wick_Front.png' WHERE Id=24");             
            Sql("UPDATE Munkaims SET eleresiUt='John_Wick_Right_Face' WHERE Id=25");             
            Sql("UPDATE Munkaims SET eleresiUt='John_Wick_Running.png' WHERE Id=26");             
            Sql("UPDATE Munkaims SET eleresiUt='Kel_Tec.png' WHERE Id=27");             
            Sql("UPDATE Munkaims SET eleresiUt='MP5.png' WHERE Id=28");             
            Sql("UPDATE Munkaims SET eleresiUt='Purple_Diamond.png' WHERE Id=29");             
            Sql("UPDATE Munkaims SET eleresiUt='SharkPool.png' WHERE Id=30");             
            Sql("UPDATE Munkaims SET eleresiUt='Taran_Tactical.png' WHERE Id=31");             
            Sql("UPDATE Munkaims SET eleresiUt='tl_jw.png' WHERE Id=32");             
            Sql("UPDATE Munkaims SET eleresiUt='top_of_the_mountain.png' WHERE Id=33");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Munkaims", "eleresiUt");
        }
    }
}
