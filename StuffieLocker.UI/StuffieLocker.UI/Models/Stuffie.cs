
using System;

namespace StuffieLocker.UI.Models;

public class Stuffie
{
    public string Name { get; set; } = string.Empty;
    public string Photo { get; set; } = string.Empty;
    public string WhyLike { get; set; } = string.Empty;
    public bool Favorite { get; set; } = false;
    public string Story { get; set; } = string.Empty;
    public DateDetails DateAquired { get; set; } = new DateDetails();
    public PlaceDetails PlaceAquired { get; set; } = new PlaceDetails();

    public class DateDetails
    {
        public bool Remember  { get; set; } = false;
        public DateTime Date { get; set; } = DateTime.MinValue;}
    }

    public class PlaceDetails
    {
        public bool Remember { get; set; } = false;
        public string Place  { get; set; } = string.Empty;
}