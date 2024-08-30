
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration; // Add this line
using Microsoft.Extensions.Configuration.Json; 
using catat.core.Models.Entities;
using System.IO; // Add this line



namespace catat.core
{
    public class MainDataContext : DbContext
    {

        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("Main");
                optionsBuilder.UseSqlServer(connectionString);
                
            }
        }


        public DbSet<CashSummaryEntity> CashSummary { get; set; }

    }

}