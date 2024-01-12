using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pustok_Backend.Areas.Admin.ViewModels.Contact;
using Pustok_Backend.Data;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Services
{
    public class ContactService:IContactService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ContactService(AppDbContext context,
                            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateAsync(ContactMessageCreateVM contact)
        {
            var data = _mapper.Map<ContactMessage>(contact);


            await _context.ContactMessages.AddAsync(data);
            await _context.SaveChangesAsync();

        }


        public async Task DeleteAsync(int? id)
        {
            if (id == null) throw new ArgumentNullException();
            ContactMessage dbContactMessage = await _context.ContactMessages.FirstOrDefaultAsync(m => m.Id == id);
            _context.ContactMessages.Remove(dbContactMessage);
            await _context.SaveChangesAsync();
        }

        public async Task<ContactMessageVM> GetMessageByIdWithoutTracking(int id)
        {
            return _mapper.Map<ContactMessageVM>(await _context.ContactMessages.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id));

        }

        public async Task<List<ContactMessageVM>> GetAllMessagesAsync()
        {
            return _mapper.Map<List<ContactMessageVM>>(await _context.ContactMessages.ToListAsync());
        }

    }
}
