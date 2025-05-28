using Weave.Models;

namespace Weave.Interfaces
{
    public interface IDataBreachService
    {
        Task<List<DataBreach>> GetAllBreachesAsync();
    }
}