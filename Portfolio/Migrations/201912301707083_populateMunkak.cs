namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMunkak : DbMigration
    {
        public override void Up()
        {   
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Abstrakt Cube','Procedural abstrakt effect. All done inside of Houdini,rendered with Mantra','2019-10-15');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Area Attack','Procedural lightning effect + smoke simulation. All done inside of Houdini, rendered with Mantra','2019-11-28');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Camp Fire','Grass and wood modelling + fire simulation. All done inside of Houdini, rendered with Octane','2019-09-09');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Curl Noise','Particle simulation with custom velocity. All done inside of Houdini, rendered with Mantra','2019-10-25');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Dragon Breath','Fire simulation with RBD simulation. All done inside of Houdini, rendered with Mantra','2019-11-07');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Explosion','Explosion simulation. All done inside of Houdini, rendered with Mantra','2019-11-28');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Fire lake','Flip fluid + fire simulation. All done inside of Houdini, rendered with Mantra','2019-11-18');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Ground Collapse','Boolean fracture simulation based on Steven Knipping tutorial. All done inside of Houdini, rendered with Mantra','2019-11-03');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'House Destruction','Fire simulation + RBD simulation. All done inside of Houdini, rendered with Mantra','2019-12-04');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Moon Destruction','Fire simulation + RBD simulation based on ripple solver. All done inside of Houdini, rendered with Mantra','2019-11-28');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Scifi Shield','Particles reacting to randomly generated shots particle simulation based on Steven Knipping tutorial. All done inside of Houdini, rendered with Mantra','2019-11-14');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Ship in Bottle','Flip fluid simulation based on Steven Knipping tutorial with vellum simulation. All done of inside Houdini, rendered with Mantra','2019-11-18');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Skull Droplets','Randomly scattered SDF generation. All done inside of Houdini, rendered with Mantra','2019-11-25');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Superhero Landing','RBD simulation with smoke simulation. All done inside of Houdini, rendered with Mantra','2019-11-28');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Thanos Portal','Particle based smoke simulation. All done inside of Houdini, rendered with Octane','2019-09-13');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'The First Meet','Procedural lightning + flip fluid simulation. All done inside of Houdini, rendered with Octane','2019-10-12');");
            Sql($"INSERT INTO Munkaims(Csillagozott,Cim,Leiras,HozzaadasDatuma) VALUES(0,'Waking Up','Particle simulation done inside of Houdini, rendered with Mantra','2019-11-26');");
        }
        
        public override void Down()
        {
        }
    }
}
