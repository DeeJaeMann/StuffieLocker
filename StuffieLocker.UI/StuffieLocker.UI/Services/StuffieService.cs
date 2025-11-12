using System;
using System.Collections.Generic;
using System.IO;
using Avalonia.Platform;
using Newtonsoft.Json;
using StuffieLocker.UI.Models;

namespace StuffieLocker.UI.Services;

public class StuffieService
{
    private List<Stuffie>? stuffieList = new();
    private readonly string jsonFilePath = "avares://StuffieLocker.UI/Assets/Data/stuffies.json";
    // var avaresJson = new StreamReader(AssetLoader.Open)

    public List<Stuffie> GetStuffies()
    {
        if(stuffieList?.Count > 0)
            return  stuffieList;
        // using (StreamReader reader = new StreamReader(jsonFilePath))
        using (StreamReader reader = new StreamReader(AssetLoader.Open(new Uri(jsonFilePath))))
        {
            JsonSerializer serializer = new JsonSerializer();
            stuffieList = (List<Stuffie>)serializer.Deserialize(reader, typeof(List<Stuffie>))!;
        }
        return stuffieList;
    }
}