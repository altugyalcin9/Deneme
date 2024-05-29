using Deneme.VarlıkEntites.Concrete;
using Deneme.VarlıkEntites.EntitiyCOnfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.VarlıkEntites.EntitiyCOnfig.Concrete
{
    public class TedarikciConfig :BaseConfig<Tedarikci>
    {
        public override void Configure(EntityTypeBuilder<Tedarikci> builder)
        {
            base.Configure(builder);
            builder.HasIndex(p => p.id).IsUnique();
            builder.Property(p => p.TedarikciAdi).HasMaxLength(80);


            builder.HasData(
         new Tedarikci { id = Guid.NewGuid().ToString(), TedarikciAdi = "Ömer Giyim" },
         new Tedarikci { id = Guid.NewGuid().ToString(), TedarikciAdi = "Arçelik" },
         new Tedarikci { id = Guid.NewGuid().ToString(), TedarikciAdi = "Vestel" },
         new Tedarikci { id = Guid.NewGuid().ToString(), TedarikciAdi = "Gratis" },
         new Tedarikci { id = Guid.NewGuid().ToString(), TedarikciAdi = "Kardeşler Kuruyemiş" }

         );
        }
    }
}
