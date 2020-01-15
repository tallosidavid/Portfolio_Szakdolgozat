namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class popExperience : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Experiences (Hol,Mit,Aktiv,Mettol,Meddig) VALUES (N'Fõvárosi Állat- és Növénykert','Application developer, Develop web pages with PHP,JavaScript and Ajax. Managed ticket sellings with MySQL and MSSQL. I worked together with Jegymester and Nemzeti Mobil Fizetés to integrate theirs system',0,'2019-05-01','2019-10-31');");
            Sql("INSERT INTO Experiences (Hol,Mit,Aktiv,Mettol,Meddig) VALUES (N'Fõvárosi Állat- és Növénykert','3D modelling, International project, I created the decoration of the under construction Pannon Parks shark pool',0,'2019-08-10','2019-10-31')");
        }
        
        public override void Down()
        {
        }
    }
}
