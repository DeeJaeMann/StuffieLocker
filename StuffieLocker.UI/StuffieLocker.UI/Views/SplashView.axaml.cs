using System;
using Avalonia.Controls;
using System.Threading.Tasks;
using Avalonia.Threading;

namespace StuffieLocker.UI.Views;

public partial class SplashView : UserControl
{
    public SplashView()
    {
        InitializeComponent();
    }
    public async Task InitApp()
    {
         long start = DateTime.Now.Ticks;
         long time = start;
         int progressValue = 0;

         while ((time - start) < TimeSpan.TicksPerSecond)
         {
             progressValue++;
             Dispatcher.UIThread.Post(() => SplashProgressBar.Value = progressValue);
             await Task.Delay(100);
             time = DateTime.Now.Ticks;
         }

         start = time;
         Dispatcher.UIThread.Post(() => LoadingText.Text = "Initializing settings");
         double limit = TimeSpan.TicksPerSecond * 2.5;
         while ((time - start) < limit)
         {
             progressValue += 1;
             Dispatcher.UIThread.Post(() => SplashProgressBar.Value = progressValue);
             await Task.Delay(150);
             time = DateTime.Now.Ticks;
         }
         
         Dispatcher.UIThread.Post(() => LoadingText.Text = "Preparing app...");

         while (progressValue < 100)
         {
             progressValue += 1;
             Dispatcher.UIThread.Post(() => SplashProgressBar.Value = progressValue);
             await Task.Delay(10);
         }
    }
}