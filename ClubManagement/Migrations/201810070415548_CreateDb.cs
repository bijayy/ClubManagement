namespace ClubManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClubCenters",
                c => new
                    {
                        ClubCenterId = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.ClubCenterId);
            
            CreateTable(
                "dbo.Clubs",
                c => new
                    {
                        ClubId = c.Int(nullable: false, identity: true),
                        ClubName = c.String(),
                        OpenDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ClubId)
                .ForeignKey("dbo.ClubCenters", t => t.ClubId)
                .Index(t => t.ClubId);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        ManagerId = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ManagerId);
            
            CreateTable(
                "dbo.Memberships",
                c => new
                    {
                        MembershipId = c.Int(nullable: false, identity: true),
                        ClubId = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                        ExpireDate = c.DateTime(nullable: false),
                        RegistrationFee = c.Decimal(nullable: false),
                    })
                .PrimaryKey(t => t.MembershipId)
                .ForeignKey("dbo.Clubs", t => t.ClubId, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.MembershipId)
                .Index(t => t.MembershipId)
                .Index(t => t.ClubId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        RegistrationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.ManagerClubs",
                c => new
                    {
                        Manager_ManagerId = c.Int(nullable: false),
                        Club_ClubId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Manager_ManagerId, t.Club_ClubId })
                .ForeignKey("dbo.Managers", t => t.Manager_ManagerId, cascadeDelete: true)
                .ForeignKey("dbo.Clubs", t => t.Club_ClubId, cascadeDelete: true)
                .Index(t => t.Manager_ManagerId)
                .Index(t => t.Club_ClubId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Memberships", "MembershipId", "dbo.People");
            DropForeignKey("dbo.Memberships", "ClubId", "dbo.Clubs");
            DropForeignKey("dbo.ManagerClubs", "Club_ClubId", "dbo.Clubs");
            DropForeignKey("dbo.ManagerClubs", "Manager_ManagerId", "dbo.Managers");
            DropForeignKey("dbo.Clubs", "ClubId", "dbo.ClubCenters");
            DropIndex("dbo.ManagerClubs", new[] { "Club_ClubId" });
            DropIndex("dbo.ManagerClubs", new[] { "Manager_ManagerId" });
            DropIndex("dbo.Memberships", new[] { "ClubId" });
            DropIndex("dbo.Memberships", new[] { "MembershipId" });
            DropIndex("dbo.Clubs", new[] { "ClubId" });
            DropTable("dbo.ManagerClubs");
            DropTable("dbo.People");
            DropTable("dbo.Memberships");
            DropTable("dbo.Managers");
            DropTable("dbo.Clubs");
            DropTable("dbo.ClubCenters");
        }
    }
}
