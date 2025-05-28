using Weave.Interfaces;

namespace Weave.Routes 
{
    public static class InfoRoutes
    {
        public static void MapInfoRoutes(this IEndpointRouteBuilder routes)
        {
            routes.MapGet("/", async (IInfoService service) => 
            {
                return await service.GetInfoAsync();
            });
        }
    }
}