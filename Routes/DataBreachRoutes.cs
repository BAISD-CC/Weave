using Weave.Interfaces;

namespace Weave.Routes 
{
    public static class DataBreachRoutes
    {
        public static void MapDataBreachRoutes(this IEndpointRouteBuilder routes)
        {
            routes.MapGet("/api/databreach", async (IDataBreachService service) => 
            {
                return await service.GetAllBreachesAsync();
            });
        }
    }
}