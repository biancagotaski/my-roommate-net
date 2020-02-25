namespace MyRoommate.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Street = c.String(),
                        Number = c.Int(nullable: false),
                        District = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Country = c.String(),
                        ZipCode = c.String(),
                        OptionalAddOn = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ads",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Address = c.String(),
                        PetFriendly = c.Boolean(nullable: false),
                        AcceptSmokers = c.Boolean(nullable: false),
                        AcceptAlcoholDrinkers = c.Boolean(nullable: false),
                        AcceptVisits = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Phone = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Biography = c.String(),
                        Photo = c.String(),
                        School = c.String(),
                        Company = c.String(),
                        HasPet = c.Boolean(),
                        Smoker = c.Boolean(),
                        DrinkAlcohol = c.Boolean(),
                        LivedOnOtherRepublic = c.Boolean(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Rooms", "PublisherId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rooms", "PublisherId");
            DropTable("dbo.Profiles");
            DropTable("dbo.Ads");
            DropTable("dbo.Addresses");
        }
    }
}
