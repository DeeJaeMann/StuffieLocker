using Microsoft.Extensions.DependencyInjection;
using StuffieLocker.UI.ViewModels;

namespace StuffieLocker.UI.Services;

public static class ServiceCollectionExtensions
{
    public static void AddCommonServices(this IServiceCollection collection)
    {
        collection.AddTransient<StuffieService>();
        collection.AddTransient<StuffiesViewModel>();
        // collection.AddTransient<MainViewModel>();
    }
}