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
      Place newPlace = new Place("test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCity_ReturnsCity_String()
    {
      string city = "Portland";
      Place newPlace = new Place(city);
      string result = newPlace.City;
      Assert.AreEqual(city, result);
    }

    [TestMethod]
  public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
  {
    //Arrange
    Place.ClearAll();
    string city = "Tampa";
    Place newPlace = new Place(city);

    //Act
    int result = newPlace.Id;

    //Assert
    Assert.AreEqual(1, result);
  }
  }
}