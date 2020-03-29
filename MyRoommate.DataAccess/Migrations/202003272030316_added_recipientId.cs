namespace MyRoommate.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_recipientId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "RecipientId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "RecipientId");
        }
    }
}
