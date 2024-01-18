using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Pustok_Backend.Areas.Admin.ViewModels.Tag;
using Pustok_Backend.Data;
using Pustok_Backend.Models;
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

        public async Task<TagVM> GetByIdWithoutTrackingAsync(int id)
        {
            return _mapper.Map<TagVM>(await _context.Tags.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id));
        }

        public Task<int> GetCountAsync()
        {
            return _context.Tags.CountAsync();
        }

        public async Task<List<TagVM>> GetPaginatedDatas(int page,int take)
        {
            return _mapper.Map<List<TagVM>>(await _context.Tags.Skip((take*page)-take).Take(take).ToListAsync());
        }

        public async Task CreateAsync(TagCreateVM tag)
        {
            Tag dbTag = _mapper.Map<Tag>(tag);

            await _context.Tags.AddAsync(dbTag);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            Tag dbTag = await _context.Tags.Where(m => m.Id == id).Include(m => m.BlogTags).FirstOrDefaultAsync();
            _context.Tags.Remove(dbTag);
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(TagEditVM tag)
        {
            Tag dbTag = await _context.Tags.AsNoTracking().FirstOrDefaultAsync(m => m.Id == tag.Id);

            _mapper.Map(tag, dbTag);

            dbTag.UpdatedDate = DateTime.Now;

            _context.Tags.Update(dbTag);

            await _context.SaveChangesAsync();
        }

        public async Task<TagVM> GetByNameWithoutTrackingAsync(string name)
        {
            return _mapper.Map<TagVM>(await _context.Tags.AsNoTracking()
                                                         .FirstOrDefaultAsync(m => m.Name.Trim().ToLower() == name.Trim().ToLower()));
        }

        public List<SelectListItem> GetAllSelectedTagsAsync()
        {
            return _context.Tags.Select(m => new SelectListItem()
            {
                Text = m.Name,
                Value = m.Id.ToString(),

            }).ToList();
        }




    }
}
