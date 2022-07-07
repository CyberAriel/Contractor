using System;
using Microsoft.EntityFrameworkCore;

namespace Contractor.Contractors
{
	public class ContractorsContext : DbContext
	{
        public ContractorsContext()
        {
        }

        
        public ContractorsContext(DbContextOptions<ContractorsContext> options) : base(options)
        {
        }
            
        public DbSet<ContractorData> Contractors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var connectionString = configuration.GetConnectionString("EFConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }


    }
}

