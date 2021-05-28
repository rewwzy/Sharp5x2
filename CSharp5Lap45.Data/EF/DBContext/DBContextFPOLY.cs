using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp5Lap45.Data.EF.Configurations;
using CSharp5Lap45.Data.EF.Entity;
using CSharp5Lap45.Data.Extensions;
using Microsoft.EntityFrameworkCore;


namespace CSharp5Lap45.Data.EF.DBContext
{
    public class DBContextFPOLY : DbContext
    {
        public DBContextFPOLY(DbContextOptions<DBContextFPOLY> options)
          : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new FStudentConfiguration());
            modelBuilder.ApplyConfiguration(new FClassConfiguration());

            //Data Seeding
            //modelBuilder.Seed();//Sau đó tiến hành chạy lại lệnh add-migration +  update-database

        }

        public DbSet<FStudent> FStudents { set; get; }
        public DbSet<FClass> FClasses { set; get; }
    }
}
