using Holocene.EventoRaptor.ApiApp.Routes.Weather;

namespace Holocene.EventoRaptor.ApiApp.Routes;

public static class RouteExtensions
{
    public static RouteHandlerBuilder MapRoutes(this WebApplication app)
    {
        return app.GetWeatherForecast()
                  ;
    }
}
