using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pustok_Backend.Areas.Admin.ViewModels.Tag;
using Pustok_Backend.Data;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Services
{
    public class TagService : ITagService
    {
        private readonly AppDbContext _context;

        private readonly IMapper _mapper;

        public TagService(AppDbContext context,
                          IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<TagVM>> GetAllAsync()
        {
            return _mapper.Map<List<TagVM>>(await _context.Tags.ToListAsync());
        }
    }
}
