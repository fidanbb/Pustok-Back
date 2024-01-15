using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pustok_Backend.Areas.Admin.ViewModels.Testimonial;
using Pustok_Backend.Data;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Services
{
    public class TestimonialService : ITestimonialService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public TestimonialService(AppDbContext context,
                                 IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        

        }
        public async Task DeleteAsync(int? id)
        {
            if(id is null) throw new ArgumentNullException();
            Testimonial testimonial = await _context.Testimonials.Where(m => m.Id == id).FirstOrDefaultAsync();
            if (testimonial is null) throw new NullReferenceException();
            _context.Testimonials.Remove(testimonial);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TestimonialVM>> GetWithIncludesAndTakeAsync(int take)
        {
            return _mapper.Map<List<TestimonialVM>>(await _context.Testimonials.Include(m => m.AppUser).Take(take).ToListAsync());
        }

        public async Task<TestimonialVM> GetByIdAsync(int id)
        {
            return _mapper.Map<TestimonialVM>(await _context.Testimonials.Include(m => m.AppUser).FirstOrDefaultAsync(m=>m.Id==id));

        }

        public async Task<List<TestimonialVM>> GetAllAsync()
        {
            return _mapper.Map<List<TestimonialVM>>(await _context.Testimonials.Include(m => m.AppUser).ToListAsync());

        }
    }
}
