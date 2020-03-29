using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRoommate.Domain.Model
{
    public class Message
    {
        public Guid Id { get; set; }
        public Guid RoomId { get; set; }
        public String SenderId { get; set; }
        public String RecipientId { get; set; }
        public String Content { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
