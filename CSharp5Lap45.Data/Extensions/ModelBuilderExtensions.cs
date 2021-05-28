using System;
using CSharp5Lap45.Data.EF.Entity;
using Microsoft.EntityFrameworkCore;

namespace CSharp5Lap45.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Lưu ý bắt buộc phải triển khai có ID vì nó cần đảm bảo vẹn toàn khi có các khóa phụ ở các bảng khác
            modelBuilder.Entity<FStudent>().HasData(
                new FStudent() { StId = 1, Mark = 5, Email = "st1@gmail.com", IdClass = 1, Name = "Dungna1" },
                new FStudent() { StId = 2, Mark = 7, Email = "st2@gmail.com", IdClass = 2, Name = "Dungna2" },
                new FStudent() { StId = 3, Mark = 2, Email = "st3@gmail.com", IdClass = 3, Name = "Dungna3" },
                new FStudent() { StId = 4, Mark = 10, Email = "st4@gmail.com", IdClass = 1, Name = "Dungna4" },
                new FStudent() { StId = 5, Mark = 8, Email = "SV5@gmail.com", IdClass = 3, Name = "Dungna5" }

            );
            modelBuilder.Entity<FClass>().HasData(
                new FClass() { IdClass = 1, NameClass = "Lop 1" },
                new FClass() { IdClass = 2, NameClass = "Lop 2" },
                new FClass() { IdClass = 3, NameClass = "Lop 3" });
        }
    }
}
