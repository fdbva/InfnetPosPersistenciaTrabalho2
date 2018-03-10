using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet.Pos.Persistencia.Trabalho2.Domain.Entities
{
    public class Order
    {
        public Order()
        {
            Albums = new List<Album>();
        }

        public int OrderId { get; set; }
        public User User { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}
