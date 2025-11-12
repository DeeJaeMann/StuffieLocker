using StuffieLocker.UI.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.Input;
using StuffieLocker.UI.Models;
using StuffieLocker.UI.Helpers;

namespace StuffieLocker.UI.ViewModels;

public partial class StuffiesViewModel : ViewModelBase
{
    private StuffieService  stuffieService;
    public ObservableCollection<Stuffie> Stuffies { get; } = new();

    public StuffiesViewModel(StuffieService stuffieService)
    {
        this.stuffieService = new StuffieService();
    }
    
    [RelayCommand]
     public void GetStuffies()
    {
        if (IsBusy)
            return;
        try
        {
            IsBusy = true;
            List<Stuffie> stuffies = stuffieService.GetStuffies();

            if (stuffies.Count != 0)
                Stuffies.Clear();

            foreach (var stuffie in stuffies)
            {
                stuffie.PhotoImage = ImageHelper.LoadFromResource(new Uri(stuffie.Photo));
                Stuffies.Add(stuffie);               
            }

            
        }
        catch (Exception ex)
        {
            // handle not loading json better
            Debug.WriteLine(ex);
            throw;
        }
        finally
        {
            IsBusy = false;
        }

    }
}