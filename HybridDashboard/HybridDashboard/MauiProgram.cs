using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using Syncfusion.Maui.Core.Hosting;

namespace HybridDashboard
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddSyncfusionBlazor(); 
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Your license key here");
            builder.Services.AddSingleton<HybridDashboard.Shared.ICardPresenter, HybridDashboard.MauiCardPresenter>();
            builder.Services.AddSingleton<MainPage>();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
