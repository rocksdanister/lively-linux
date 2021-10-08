using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using System;
using System.IO;
using System.Threading;

namespace lively
{
    class Program
    {
        //private static readonly string uniqueAppName = "LIVELY:DESKTOPWALLPAPERSYSTEM";
        //private static readonly Mutex mutex = new Mutex(false, uniqueAppName);
        public static string WallpaperDir { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "userdata", "library");
        public static string AppDataDir { get; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "userdata");


        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        public static void Main(string[] args) => BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace();
    }
}
