using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.VarlıkEntites.Abstract
{
    public class BaseEntity
    {
        public string id {  get; set; }
        public DateTime olusturulmaTarihi { get; set; }= DateTime.UtcNow;
    }
}

//KAtegori:id,olşTH,Adı,
//Urunler:id,olşTRH,ÜrünAdi,Kategorisi,tedarikçi