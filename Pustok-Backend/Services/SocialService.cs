using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pustok_Backend.Areas.Admin.ViewModels.Social;
using Pustok_Backend.Data;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Services
{
    public class SocialService : ISocialService
    {
        private readonly AppDbContext  _context;
        private readonly IMapper _mapper;

        public SocialService(AppDbContext context,
                            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task EditAsync(SocialEditVM social)
        {
            Social dbSocial = await _context.Socials.AsNoTracking().FirstOrDefaultAsync(m => m.Id == social.Id);

            _mapper.Map(social, dbSocial);

            dbSocial.UpdatedDate = DateTime.Now;

            _context.Socials.Update(dbSocial);

            await _context.SaveChangesAsync();
        }

        public async Task<List<SocialVM>> GetAllAsync()
        {
            return _mapper.Map<List<SocialVM>>(await _context.Socials.ToListAsync());
        }

        public async Task<SocialVM> GetByIdWithoutTrackingAsync(int id)
        {
            return _mapper.Map<SocialVM>(await _context.Socials.AsNoTracking().FirstOrDefaultAsync(m=>m.Id==id));
        }
    }
}
