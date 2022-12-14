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
      Place newPlace = new Place("test", "test1", "test 2");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCity_ReturnsCity_String()
    {
      string city = "Portland";
      string time = "3 days";
      string entry = "amazing";
      Place newPlace = new Place(city, time, entry);
      string result = newPlace.City;
      Assert.AreEqual(city, result);
    }

    [TestMethod]
  public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
  {
    //Arrange
    Place.ClearAll();
    string city = "Tampa";
    string time = "3 days";
    string entry = "amazing";
    Place newPlace = new Place(city, time, entry);

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
    string time01 = "Two days";
    string entry01 = "cool";
    string city02 = "Denver";
    string time02 = "Dos dias";
    string entry02 = "Dont go here";
    Place newPlace01 = new Place(city01, time01, entry01);
    Place newPlace02 = new Place(city02, time02, entry02);

    Place result = Place.Find(2);

    Assert.AreEqual(newPlace02, result);
  }
  }
}