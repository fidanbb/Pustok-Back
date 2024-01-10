using Pustok_Backend.Models;

namespace Pustok_Backend.Services.Interfaces
{
    public interface IDirectionService
    {
        Task<List<Direction>> GetAllAsync();
    }
}
