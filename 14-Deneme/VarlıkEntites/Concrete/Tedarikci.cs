using Deneme.VarlıkEntites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.VarlıkEntites.Concrete
{
    public class Tedarikci:BaseEntity
    {
        public string TedarikciAdi {  get; set; }
        public ICollection<Urun> urunler {  get; set; }
    }
}
