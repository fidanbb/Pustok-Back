using Pustok_Backend.Areas.Admin.ViewModels.Contact;

namespace Pustok_Backend.Services.Interfaces
{
    public interface IContactService
    {
        Task<List<ContactMessageVM>> GetAllMessagesAsync();
        Task CreateAsync(ContactMessageCreateVM contact);

        Task DeleteAsync(int? id);
        Task<ContactMessageVM> GetMessageByIdWithoutTracking(int id);
    }
}
