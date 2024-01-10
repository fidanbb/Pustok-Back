using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Services.Interfaces;
using Pustok_Backend.ViewModels.Layout;

namespace Pustok_Backend.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {

        private readonly ILayoutService _layoutService;

        public FooterViewComponent(ILayoutService layoutService)
        {
            _layoutService = layoutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            FooterVM model = await _layoutService.GetFooterDatas();


            return await Task.FromResult(View(model));
        }
    }
}
