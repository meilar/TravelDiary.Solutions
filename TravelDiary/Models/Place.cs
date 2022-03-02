using System.Collections.Generic;
using System;

namespace TravelDiary.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public int Id { get; }
    private static List<Place> _passport = new List<Place>{ };

    public Place(string cityName)
    {
      CityName = cityName;
      _passport.Add(this);
      Id = _passport.Count;
    }
  }
}