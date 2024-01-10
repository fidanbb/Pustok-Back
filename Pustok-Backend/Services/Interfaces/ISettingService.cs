using Pustok_Backend.Areas.Admin.ViewModels.Setting;
using Pustok_Backend.Models;

namespace Pustok_Backend.Services.Interfaces
{
    public interface ISettingService
    {
        Dictionary<string, string> GetSettings();

        Task<List<Setting>> GetAllAsync();

        Task<Setting> GetByIdAsync(int id);
        Task EditAsync(SettingEditVM setting);
    }
}
