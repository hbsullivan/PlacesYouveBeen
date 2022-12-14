using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    public string City { get; set; }
    public string Time { get; set; }
    public string Entry { get; set; }

    public int Id { get; }
    private static List<Place> _instances = new List<Place> {};

    public Place(string city, string time, string entry)
    {
      City = city;
      Time = time;
      Entry = entry;
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