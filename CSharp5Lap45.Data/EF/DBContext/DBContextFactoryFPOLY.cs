using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5Lap45.Data.EF.DBContext
{
    public class DBContextFactoryFPOLY : IDesignTimeDbContextFactory<DBContextFPOLY>
    {
        public DBContextFPOLY CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();

            var connectionString = configuration.GetConnectionString("FPTPOLYCHSARP5DH");
            var optionBuilder = new DbContextOptionsBuilder<DBContextFPOLY>();
            optionBuilder.UseSqlServer(connectionString);
            return new DBContextFPOLY(optionBuilder.Options);

        }
    }
}
