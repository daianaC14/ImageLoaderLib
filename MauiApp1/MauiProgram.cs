﻿using Microsoft.Extensions.Logging;

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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<MainPagee>();
            builder.Services.AddTransient<MainPageee>();
            builder.Services.AddTransient<MainPageeee>();

            return builder.Build();
        }
    }
}
