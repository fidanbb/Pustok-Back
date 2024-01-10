using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pustok_Backend.Areas.Admin.ViewModels.Service;
using Pustok_Backend.Data;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Services
{
    public class SiteServicesService : ISiteServicesService
    {
        private readonly AppDbContext _context;

        private readonly IMapper _mapper;

        public SiteServicesService(AppDbContext context,
                                    IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task EditAsync(ServiceEditVM service)
        {
            Service dbService = await _context.Services.AsNoTracking().FirstOrDefaultAsync(m => m.Id == service.Id);

            _mapper.Map(service, dbService);

            dbService.UpdatedDate = DateTime.Now;

            _context.Services.Update(dbService);

            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<ServiceVM>> GetAllAsync() => _mapper.Map<List<ServiceVM>>(await _context.Services.ToListAsync());

        public async Task<ServiceVM> GetByIdWithoutTracking(int id) => _mapper.Map<ServiceVM>(await _context.Services.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id));
    }
}
