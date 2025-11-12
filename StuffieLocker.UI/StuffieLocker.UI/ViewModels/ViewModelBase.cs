using CommunityToolkit.Mvvm.ComponentModel;

namespace StuffieLocker.UI.ViewModels;

public partial class ViewModelBase : ObservableObject
{
    [ObservableProperty] 
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    private bool isBusy;
    
    public bool IsNotBusy => !IsBusy;
}
