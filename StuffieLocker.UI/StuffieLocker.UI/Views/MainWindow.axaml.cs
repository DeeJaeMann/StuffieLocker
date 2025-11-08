using Avalonia.Controls;
using FluentAvalonia.UI.Windowing;
using StuffieLocker.UI.Classes;

namespace StuffieLocker.UI.Views;

public partial class MainWindow : AppWindow
{
    public MainWindow()
    {
        InitializeComponent();
        TitleBar.ExtendsContentIntoTitleBar = true;
        TitleBar.TitleBarHitTestType = TitleBarHitTestType.Complex;
        SplashScreen = new ComplexSplashScreen();
    }
}