using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRoommate.Domain.Model
{
    public class Room
    {
        public Guid Id { get; set; }
        public string PublisherId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public decimal Price { get; set; }
    }
}
