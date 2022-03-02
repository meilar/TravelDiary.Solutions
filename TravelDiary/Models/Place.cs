using System.Collections.Generic;
using System;

namespace TravelDiary.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public int Id { get; }
    public string Highlights { get;}
    private static List<Place> _passport = new List<Place>{ };

    public static List<Place> GetAll()
    {
      return _passport;
    }

    public static void ClearAll()
    {
      _passport.Clear();
    }
    public Place(string cityName, string highlights)
    {
      CityName = cityName;
      _passport.Add(this);
      Id = _passport.Count;
      Highlights = highlights;
    }
  }
}