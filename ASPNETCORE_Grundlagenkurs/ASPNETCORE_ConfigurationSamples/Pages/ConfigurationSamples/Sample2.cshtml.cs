using ASPNETCORE_ConfigurationSamples.Configurations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace ASPNETCORE_ConfigurationSamples.Pages.ConfigurationSamples
{
    public class Sample2Model : PageModel
    {
        private GameSettings GameConfigSettings { get; set; }

        //IOptionSnapshot -> kann modifizierungen an der AppSetting.json mitbekommen
        public Sample2Model(IOptionsSnapshot<GameSettings> gameSettings)
        {
            GameConfigSettings = gameSettings.Value;
        }

        public ContentResult OnGet()
        {
            return Content(GameConfigSettings.Title);
        }
    }
}
