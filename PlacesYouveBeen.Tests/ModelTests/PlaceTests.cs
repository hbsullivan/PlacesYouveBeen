using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesYouveBeen.Models;

namespace PlacesYouveBeen.Tests
{
  [TestClass]
  public class PlaceTests
  {
    [TestMethod]
    public void PlaceConstructor_CreateInstanceOfPlace_Place()
    {
      Place newPlace = new Place();
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
  }
}