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
    public class KategoriConfig : BaseConfig<Kategori>
    {
        public override void Configure(EntityTypeBuilder<Kategori> builder)
        {
            base.Configure(builder);
            builder.HasIndex(p => p.KategoriAdi).IsUnique();
            builder.HasIndex(p => p.id).IsUnique();
            builder.Property(p=>p.KategoriAdi).HasMaxLength(30);

            builder.HasData(
         new Kategori { id = Guid.NewGuid().ToString(), KategoriAdi = "Teknoloji" },
         new Kategori { id = Guid.NewGuid().ToString(), KategoriAdi = "Giyim" },
         new Kategori { id = Guid.NewGuid().ToString(), KategoriAdi = "Gıda" },
         new Kategori { id = Guid.NewGuid().ToString(), KategoriAdi = "Kozmetik"}
         );
        }
    }
}
