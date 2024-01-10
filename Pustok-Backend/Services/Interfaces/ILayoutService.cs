using Pustok_Backend.ViewModels.Layout;

namespace Pustok_Backend.Services.Interfaces
{
    public interface ILayoutService
    {
        HeaderVM GetHeaderDatas();
        FooterVM GetFooterDatas();

    }
}
