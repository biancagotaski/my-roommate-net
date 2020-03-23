using MyRoommate.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRoommate.DataAccess.Contexts
{
    public class MyRoommateContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Message> Messages { get; set; }

        public MyRoommateContext():
            base("Server=tcp:myroommate-db-server.database.windows.net,1433;Initial Catalog=myroommate-db;Persist Security Info=False;User ID=bianca;Password=Myroommate!2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        {
        }
    }
}
