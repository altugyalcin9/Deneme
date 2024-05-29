using Deneme.VarlıkEntites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.VarlıkEntites.Concrete
{
    public class Urun:BaseEntity
    {
        public string UrunlerAdi { get; set; }
        public ICollection<Kategori>kategori { get; set; }
        public string TedarikciID { get; set; }
        public Tedarikci tedarikciler { get; set; }
    }
}
