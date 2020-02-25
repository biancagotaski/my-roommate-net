namespace MyRoommate.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyRoommate.DataAccess.Contexts.MyRoommateContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MyRoommate.DataAccess.Contexts.MyRoommateContext";
        }

        protected override void Seed(MyRoommate.DataAccess.Contexts.MyRoommateContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
