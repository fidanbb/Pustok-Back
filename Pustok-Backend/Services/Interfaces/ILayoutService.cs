using Pustok_Backend.ViewModels.Layout;

namespace Pustok_Backend.Services.Interfaces
{
    public interface ILayoutService
    {
        Task<HeaderVM> GetHeaderDatas();
        Task<FooterVM> GetFooterDatas();

    }
}
