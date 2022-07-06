using System;
using Microsoft.EntityFrameworkCore;

namespace Contractor.Contractors
{
	public class ContractorsContext : DbContext
	{
        public ContractorsContext()
        {
        }

        //Constructor with DbContextOptions and the context class itself
        public ContractorsContext(DbContextOptions<ContractorsContext> options) : base(options)
        {
        }
        //Create the DataSet for the Employee         
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

