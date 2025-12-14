using Microsoft.Extensions.Logging;

namespace MauiApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                    //Autumnn's way better fonts
                    fonts.AddFont("FacultyGlyphic-Regular.ttf", "FacultyGlyphicRegular");
                    fonts.AddFont("Ubuntu-Regular.ttf", "UbuntuRegular");
                });

            builder.Services.AddSingleton<CartService>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
