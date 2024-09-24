using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;

namespace IT2.Invoice.Data.EF
{
    public class IT2DbContextFactory : IDesignTimeDbContextFactory<IT2DbContext>
    {
        public IT2DbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

      
            var connectionString = configuration.GetConnectionString("invoiceSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<IT2DbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new IT2DbContext(optionsBuilder.Options);
        }
    }
}
