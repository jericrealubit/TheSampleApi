using System.Runtime.CompilerServices;

namespace TheSampleApi.Endpoints;

public static class RootEndpoints
{
    public static void AddRootEndpoints(this WebApplication app)
    {
        app.MapGet("/", () => "Hello world");
    }
}
