using System.Threading;
using System.Threading.Tasks;
using Avalonia.Media;
using FluentAvalonia.UI.Windowing;
using StuffieLocker.UI.Views;

namespace StuffieLocker.UI.Classes;

public class ComplexSplashScreen : IApplicationSplashScreen
{
    public ComplexSplashScreen()
    {
        SplashScreenContent = new SplashView();
    }

    public string AppName => "";
    public IImage? AppIcon => null;
    public object SplashScreenContent { get; }
    public int MinimumShowTime => 0;

    public async Task RunTasks(CancellationToken token)
    {
        await ((SplashView)SplashScreenContent).InitApp();
    }
}