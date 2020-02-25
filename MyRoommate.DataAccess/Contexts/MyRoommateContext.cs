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

        public MyRoommateContext():
            base("Server=tcp:myroommate-db-server.database.windows.net,1433;Initial Catalog=MyRoommate-Db;Persist Security Info=False;User ID=themasterkey;Password=@dsInf123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        {
        }
    }
}
