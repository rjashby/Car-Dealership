using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership {

  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, 76);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000, 13);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001, 3);
      Car amc = new Car("1976 AMC Pacer", 400, 198000, 93);

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };
      Console.WriteLine("What should our percent off be?");
      int myPercentoff = Convert.ToInt32(Console.ReadLine());
      // yugo.MakeModel = "2020 Tesla";
      // yugo.Price = 400;

    //   Console.WriteLine("Enter maximum price: ");
    //   string stringMaxPrice = Console.ReadLine();
    //   int maxPrice = int.Parse(stringMaxPrice);

    //   List<Car> CarsMatchingSearch = new List<Car>(0);

    //   foreach (Car automobile in Cars)
    //   {
    //     if (automobile.WorthBuying(maxPrice))
    //     {
    //       CarsMatchingSearch.Add(automobile);
    //     }
    //   }

    //   foreach(Car automobile in CarsMatchingSearch)
    //   {
    //     Console.WriteLine("----------------------");
    //     Console.WriteLine(automobile.MakeModel);
    //     Console.WriteLine(automobile.Miles + " miles");
    //     Console.WriteLine("$" + automobile.Price);
    //   }
    // }
    foreach(Car autos in Cars)
    {
      autos.SalePrice(myPercentoff);
      Console.WriteLine("----------------------");
      Console.WriteLine("Our Cars are now " + myPercentoff + "% off");
      Console.WriteLine(autos.MakeModel);
      Console.WriteLine("$" + autos.Price);
    }
    Cars.Sort()
    foreach(Car autos in Cars)
    {
      // autos.Sort(OffRoadAbility);
    }
  }

}
}