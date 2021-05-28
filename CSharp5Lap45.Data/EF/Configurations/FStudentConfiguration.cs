using CSharp5Lap45.Data.EF.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CSharp5Lap45.Data.EF.Configurations
{
    public class FStudentConfiguration : IEntityTypeConfiguration<FStudent>
    {
        public void Configure(EntityTypeBuilder<FStudent> builder)
        {
            builder.ToTable("FStudent");
            builder.HasKey(x => x.StId);
            builder.HasOne(x => x.FClass).WithMany(x => x.FStudents).HasForeignKey(x=>x.IdClass);
        }
    }
}
