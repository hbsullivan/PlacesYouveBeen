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

  [TestMethod]
  public void Find_ReturnCorrectPlace_Place()
  {
    Place.ClearAll();
    string city01 = "Tampa";
    string city02 = "Denver";
    Place newPlace01 = new Place(city01);
    Place newPlace02 = new Place(city02);

    Place result = Place.Find(2);

    Assert.AreEqual(newPlace02, result);
  }
  }
}