using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TravelDiary.Models;

namespace TravelDiary.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {

    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void Constructor_CreatesPlace_Place()
    {
      Place newPlace = new Place("Bahamas", "Beach, Scuba Diving");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
      Assert.AreEqual("Bahamas", newPlace.CityName);
      Assert.AreEqual(1, newPlace.Id);
      Assert.AreEqual("Beach, Scuba Diving", newPlace.Highlights);
    }

    [TestMethod]
    public void GetAll_Return_passport_True()
    {
      Assert.AreEqual(0, Place.GetAll().Count);
      Place newPlace = new Place("Bahamas", "Beach, Scuba Diving");
      Assert.AreEqual(1, Place.GetAll().Count);
    }

  }
}