using CSharp5Lap45.Data.EF.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5Lap45.Data.EF.Configurations
{
    public class FClassConfiguration : IEntityTypeConfiguration<FClass>
    {
        public void Configure(EntityTypeBuilder<FClass> builder)
        {
            builder.ToTable("FClass");
            builder.HasKey(x => x.IdClass);
        }
    }
}
