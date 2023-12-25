using Holocene.EventoRaptor.WebApp.Models;

namespace Holocene.EventoRaptor.WebApp.Clients;

public interface IApiAppClient
{
    Task<List<WeatherForecastModel>> GetWeatherForecastAsync();
}

public class ApiAppClient(HttpClient http) : IApiAppClient
{
    private readonly HttpClient _http = http ?? throw new ArgumentNullException(nameof(http));

    public async Task<List<WeatherForecastModel>> GetWeatherForecastAsync()
    {
        var result = await this._http.GetFromJsonAsync<List<WeatherForecastModel>>("weatherforecast").ConfigureAwait(false);

        return result;
    }
}
