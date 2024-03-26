using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoForecastSC.Server.Models
{
	[Table("live-forecast")]
	public class LiveForecast
	{
			[Key]
			[Column("id")]
			public int Id { get; set; }

			[Column("location")]
			public string Location { get; set; }

			[Column("date")]
			public DateOnly Date { get; set; }

			[Column("wind")]
			public string Wind { get; set; }

			[Column("air-quality")]
			public string AirQuality { get; set; }

			[Column("celsius")]
			public string Celsius { get; set; }

			[Column("fahrenheit")]
			public string Fahrenheit { get; set; }

			[Column("summary")]
			public string Summary { get; set; }
		
	}
}
