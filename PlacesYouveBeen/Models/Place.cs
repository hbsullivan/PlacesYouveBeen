using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    public string City { get; set; }
    private static List<Place> _instances = new List<Place> {};

    public Place(string city)
    {
      City = city;
      _instances.Add(this);
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}