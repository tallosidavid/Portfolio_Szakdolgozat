namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMunkak : DbMigration
    {
        public override void Up()
        {   
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Abstrakt Cube','Procedural abstrakt effect. All done inside of Houdini,rendered with Mantra','{DateTime.Now.ToString("yyyy - MM - dd")}');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Area Attack','Procedural lightning effect + smoke simulation. All done inside of Houdini, rendered with Mantra','{DateTime.Now.ToString("yyyy - MM - dd")}');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Camp Fire','Grass and wood modelling + fire simulation. All done inside of Houdini, rendered with Octane','{DateTime.Now.ToString("yyyy - MM - dd")}');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Curl Noise','Particle simulation with custom velocity. All done inside of Houdini, rendered with Mantra','{DateTime.Now.ToString("yyyy - MM - dd")}');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Dragon Breath','Fire simulation with RBD simulation. All done inside of Houdini, rendered with Mantra','{DateTime.Now.ToString("yyyy - MM - dd")}');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Explosion','Explosion simulation. All done inside of Houdini, rendered with Mantra','{DateTime.Now.ToString("yyyy - MM - dd")}');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Fire lake','Flip fluid + fire simulation. All done inside of Houdini, rendered with Mantra','{DateTime.Now.ToString("yyyy - MM - dd")}');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Ground Collapse','Boolean fracture simulation based on Steven Knipping tutorial. All done inside of Houdini, rendered with Mantra','{DateTime.Now.ToString("yyyy - MM - dd")}');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'House Destruction','Fire simulation + RBD simulation. All done inside of Houdini, rendered with Mantra','{DateTime.Now.ToString("yyyy - MM - dd")}');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Moon Destruction','Fire simulation + RBD simulation based on ripple solver. All done inside of Houdini, rendered with Mantra','{DateTime.Now.ToString("yyyy - MM - dd")}');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Scifi Shield','Particles reacting to randomly generated shots. All done inside of Houdini, rendered with Mantra','{DateTime.Now.ToString("yyyy - MM - dd")}');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Ship in Bottle','Flip fluid simulation based on Steven Knipping tutorial with vellum simulation. All done of inside Houdini, rendered with Mantra','{DateTime.Now.ToString("yyyy - MM - dd")}');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Skull Droplets','Randomly scattered SDF generation. All done inside of Houdini, rendered with Mantra','{DateTime.Now.ToString("yyyy - MM - dd")}');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Superhero Landing','RBD simulation with smoke simulation. All done inside of Houdini, rendered with Mantra','{DateTime.Now.ToString("yyyy - MM - dd")}');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Thanos Portal','Particle based smoke simulation. All done inside of Houdini, rendered with Octane','{DateTime.Now.ToString("yyyy - MM - dd")}');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'The First Meet','Procedural lightning + flip fluid simulation. All done inside of Houdini, rendered with Octane','{DateTime.Now.ToString("yyyy - MM - dd")}');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Waking Up','Particle simulation done inside of Houdini, rendered with Mantra','{DateTime.Now.ToString("yyyy - MM - dd")}');");
        }
        
        public override void Down()
        {
        }
    }
}
