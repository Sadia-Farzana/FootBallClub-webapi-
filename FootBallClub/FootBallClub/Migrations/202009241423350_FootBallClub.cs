namespace FootballClub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FootBallClub : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coaches",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Password = c.String(maxLength: 50, unicode: false),
                        Name = c.String(maxLength: 50, unicode: false),
                        Age = c.String(maxLength: 50, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        Phone = c.String(maxLength: 50, unicode: false),
                        Address = c.String(maxLength: 50, unicode: false),
                        Designation = c.String(maxLength: 50, unicode: false),
                        Salary = c.Double(nullable: false),
                        Image = c.String(maxLength: 200, unicode: false),
                        SignUp_userName = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.UserName)
                .ForeignKey("dbo.Admins", t => t.SignUp_userName)
                .Index(t => t.SignUp_userName);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        userName = c.String(nullable: false, maxLength: 50, unicode: false),
                        name = c.String(nullable: false, maxLength: 50, unicode: false),
                        password = c.String(nullable: false, maxLength: 11, unicode: false),
                        email = c.String(nullable: false, maxLength: 50, unicode: false),
                        phone = c.Int(nullable: false),
                        salary = c.Double(nullable: false),
                        image = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.userName);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(maxLength: 50, unicode: false),
                        description = c.String(maxLength: 50, unicode: false),
                        userName = c.String(nullable: false, maxLength: 50, unicode: false),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        userName = c.String(nullable: false, maxLength: 50, unicode: false),
                        name = c.String(nullable: false, maxLength: 50, unicode: false),
                        password = c.String(nullable: false, maxLength: 11, unicode: false),
                        age = c.Int(nullable: false),
                        email = c.String(nullable: false, maxLength: 50, unicode: false),
                        address = c.String(nullable: false, maxLength: 50, unicode: false),
                        phone = c.Int(nullable: false),
                        position = c.String(maxLength: 50, unicode: false),
                        salary = c.Double(nullable: false),
                        type = c.String(nullable: false, maxLength: 50, unicode: false),
                        image = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.userName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Coaches", "SignUp_userName", "dbo.Admins");
            DropIndex("dbo.Coaches", new[] { "SignUp_userName" });
            DropTable("dbo.Players");
            DropTable("dbo.Notifications");
            DropTable("dbo.Admins");
            DropTable("dbo.Coaches");
        }
    }
}
