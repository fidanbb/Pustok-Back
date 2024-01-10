using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pustok_Backend.Areas.Admin.ViewModels.Subscribe;
using Pustok_Backend.Data;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Services
{
    public class SubscribeService : ISubscribeService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public SubscribeService(AppDbContext context,
                                IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<SubscribeVM>> GetAllAsync()
        {
            return _mapper.Map<List<SubscribeVM>>(await _context.Subscribes.ToListAsync());
        }

        public async Task CreateAsync(SubscribeCreateVM subscribe)
        {
            var data = _mapper.Map<Subscribe>(subscribe);

            await _context.Subscribes.AddAsync(data);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int? id)
        {
            if(id is null) throw new ArgumentNullException();
            Subscribe subscribe = await _context.Subscribes.Where(m => m.Id == id).FirstOrDefaultAsync();
            if (subscribe is null) throw new NullReferenceException();
            
            _context.Subscribes.Remove(subscribe);
            await _context.SaveChangesAsync();
        }

        public async Task<SubscribeVM> GetByEmailAsync(string email)
        {
            return _mapper.Map<SubscribeVM>(await _context.Subscribes.FirstOrDefaultAsync(m => m.Email == email));
        }
    }
}
