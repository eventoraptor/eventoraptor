using Holocene.EventoRaptor.ApiApp.Models;

namespace Holocene.EventoRaptor.ApiApp.Routes.Weather;

public static partial class WeatherForecastExtensions
{
    private static string[] summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public static RouteHandlerBuilder GetWeatherForecast(this WebApplication app)
    {
        return app.MapGet("/weatherforecast", async () =>
        {
            var forecast =  Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)]
                ))
                .ToArray();

            return await Task.FromResult(forecast).ConfigureAwait(false);
        })
        .WithName("GetWeatherForecast")
        .WithOpenApi();
    }
}
