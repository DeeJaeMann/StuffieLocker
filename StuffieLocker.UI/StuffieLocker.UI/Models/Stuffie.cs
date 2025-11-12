
using System;
using Avalonia.Media.Imaging;

namespace StuffieLocker.UI.Models;

public class Stuffie
{
    public string Name { get; set; } = string.Empty;
    public string Photo { get; set; } = string.Empty;
    public Bitmap? PhotoImage { get; set; } = null;
    public string WhyLike { get; set; } = string.Empty;
    public bool Favorite { get; set; } = false;
    public string Story { get; set; } = string.Empty;
    public DateTime? DateAquired { get; set; } = null;
    public string PlaceAquired { get; set; } = string.Empty;

}