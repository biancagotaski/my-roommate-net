namespace MyRoommate.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Messages",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            SenderId = c.String(),
            //            RecipientId = c.String(),
            //            Content = c.String(),
            //            Timestamp = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.Rooms",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            PublisherId = c.String(),
            //            Title = c.String(),
            //            Description = c.String(),
            //            Address = c.String(),
            //            Photo = c.String(),
            //            Price = c.Decimal(nullable: false, precision: 18, scale: 2),
            //        })
            //    .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rooms");
            DropTable("dbo.Messages");
        }
    }
}
