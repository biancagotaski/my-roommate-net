namespace MyRoommate.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_messages2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                {
                    Id = c.Guid(nullable: false),
                    SenderId = c.String(),
                    RecipientId = c.String(),
                    Content = c.String(),
                    Timestamp = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
        }
    }
}
