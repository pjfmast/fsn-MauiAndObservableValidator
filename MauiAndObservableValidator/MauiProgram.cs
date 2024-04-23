using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using MauiAndObservableValidator.ViewModels;
using MauiAndObservableValidator.Services;

namespace MauiAndObservableValidator
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            }).UseMauiCommunityToolkit();
#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<IDialogService, DialogService>();

            builder.Services.AddTransient<AddRatingPage>();
            builder.Services.AddTransient<AddRatingViewModel>();

            return builder.Build();
        }
    }
}