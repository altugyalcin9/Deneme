using Deneme.VarlıkEntites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.VarlıkEntites.Concrete
{
    public class Kategori:BaseEntity
    {
        public string KategoriAdi { get; set; }
        public ICollection<Urun> Urunler { get; set; } 
    }
}
