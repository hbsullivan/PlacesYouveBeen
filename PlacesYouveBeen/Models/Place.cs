using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    public string City { get; set; }
    public int Id { get; }
    private static List<Place> _instances = new List<Place> {};

    public Place(string city)
    {
      City = city;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}