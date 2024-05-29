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
    public class UrunConfig:BaseConfig<Urun>
    {
        public override void Configure(EntityTypeBuilder<Urun> builder)
        {
            base.Configure(builder);
            builder.HasIndex(p => p.id).IsUnique();
            builder.Property(p => p.UrunlerAdi).HasMaxLength(80);
           
         //   builder.HasData(
         //   new Urun { id = Guid.NewGuid().ToString(), UrunlerAdi = "Abra a5 2716"},
         //   new Urun { id = Guid.NewGuid().ToString(), UrunlerAdi = "Maskara"},
         //   new Urun { id = Guid.NewGuid().ToString(), UrunlerAdi = "Leblebi"},
         //   new Urun { id = Guid.NewGuid().ToString(), UrunlerAdi = "Kırmızı S765-Likralı"}
         //);


        }
    }
}
