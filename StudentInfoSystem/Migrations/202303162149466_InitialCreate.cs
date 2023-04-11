namespace StudentInfoSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Ime1 = c.String(),
                        Prezime1 = c.String(),
                        Familia1 = c.String(),
                        Faklutet1 = c.String(),
                        Specialnost1 = c.String(),
                        ObrazovatelnoKvalifikacionnaStepen1 = c.String(),
                        Status1 = c.String(),
                        FaklutetenNomer1 = c.String(),
                        Kurs1 = c.Int(nullable: false),
                        Potok1 = c.Int(nullable: false),
                        Grupa1 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username1 = c.String(),
                        Password1 = c.String(),
                        FakNum1 = c.String(),
                        Role1 = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ActiveTo = c.DateTime(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Students");
        }
    }
}
