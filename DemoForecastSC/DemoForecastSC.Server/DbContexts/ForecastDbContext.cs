using DemoForecastSC.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoForecastSC.Server.DbContexts
{
	public class ForecastDbContext : DbContext
	{
		public DbSet<LiveForecast> liveForecasts { get; set; }

		public ForecastDbContext()
		{
			AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var configurationInstance = new ConfigurationBuilder()
				   .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)?.FullName ?? ".")
				  // .AddJsonFile("appSettings.json", optional: true)
				   .AddJsonFile("appSettings.local.json", optional: true)
				   .Build();

			string dbConnString = configurationInstance["ConnectionStrings:forecastDbUser"] ?? "";
			optionsBuilder.UseNpgsql(dbConnString);
			base.OnConfiguring(optionsBuilder);
		}
	}
}
