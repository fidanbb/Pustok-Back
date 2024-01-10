using Microsoft.EntityFrameworkCore;
using Pustok_Backend.Data;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Services
{
    public class DirectionService:IDirectionService
    {
        private readonly AppDbContext _context;

        public DirectionService(AppDbContext context   )
        {
            _context = context;
        }

        public async Task<List<Direction>> GetAllAsync()
        {
            return await _context.Directions.ToListAsync();
        }
    }
}
