using System;

namespace Dealership.Models
{
  public class Car
  {
    // Public auto-implemented properties

    public string MakeModel {get; set; }
    public int Price {get; set; }
    public int Miles {get; set; }

    // Constructor
    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

    // public static string MakeSound(string sound)
    // {
    //   return "Our carrs sound like " + sound;
    // }

    // public void SetPrice(int newPrice)
    // {
    //   _price = newPrice;
    // }

    // public string GetMakeModel()
    // {
    //   return _makeModel;
    // }

    // public int GetPrice()
    // {
    //   return _price;
    // }

    // public int GetMiles()
    // {
    //   return _miles;
    // }

    // public bool WorthBuying(int maxPrice)
    // {
    //   return (_price <= maxPrice);
    // }

    // private string _makeModel;

    // public string MakeModel 
    // {
    //   get 
    //   {
    //     // return _makeModel;
    //     return "That's a big secret. You'll have to visit Lonny's to find out about our special deals!";
    //   }
    //   set 
    //   {
    //     _makeModel = value;
    //   }
    // }
  }
}
