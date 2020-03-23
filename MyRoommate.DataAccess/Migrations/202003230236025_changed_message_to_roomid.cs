namespace MyRoommate.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changed_message_to_roomid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "RoomId", c => c.Guid(nullable: false));
            DropColumn("dbo.Messages", "RecipientId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "RecipientId", c => c.String());
            DropColumn("dbo.Messages", "RoomId");
        }
    }
}
