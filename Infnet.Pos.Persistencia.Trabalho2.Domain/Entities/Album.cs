using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet.Pos.Persistencia.Trabalho2.Domain.Entities
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Genre Genre { get; set; }
    }
}
