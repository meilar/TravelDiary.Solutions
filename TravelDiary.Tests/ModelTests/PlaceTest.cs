using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TravelDiary.Models;

namespace TravelDiary.Tests
{
  [TestClass]
  public class PlaceTests
  {
    [TestMethod]
    public void Constructor_CreatesPlace_Place()
    {
      Place newPlace = new Place("Bahamas");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
  }
}