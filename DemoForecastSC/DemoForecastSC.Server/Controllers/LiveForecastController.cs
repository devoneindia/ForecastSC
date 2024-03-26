using DemoForecastSC.Server.DbContexts;
using DemoForecastSC.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoForecastSC.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LiveForecastController : ControllerBase
	{
		private readonly  ForecastDbContext forecastDbContext;

		public LiveForecastController(ForecastDbContext forecastDb)
		{
			forecastDbContext = forecastDb;
		}

		[HttpPost]
		public async Task<IActionResult> SaveUserInfo([FromBody] LiveForecast liveForecast)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			// Save user data to the database
			forecastDbContext.liveForecasts.Add(liveForecast);
			await forecastDbContext.SaveChangesAsync();

			return Ok(liveForecast);
		}
	}
}
