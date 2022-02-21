using System;
using System.Collections.Generic;
using Dealership.Models;
using System.Linq;

namespace Dealership {
  public class Program
  {

  public static void Main()
    {
      Car volkswagen = new Car("Volkswagen Thing", 1974, 1100, 368792, 76);
      Car yugo = new Car("Yugo Koral", 1980, 700, 56000, 13);
      Car ford = new Car("Ford Country Squire", 1988, 1400, 239001, 3);
      Car amc = new Car("AMC Pacer", 1976, 400, 198000, 93);
      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };
        
    //Change price based on car year
      foreach(Car auto in Cars) {
        auto.YearBasedPrice();
        Console.WriteLine("Your " + auto.MakeModel + " is worth $" + auto.Price);
      }
    // SET PROPERTIES OR GET PROPERTIES

    // yugo.MakeModel = "2020 Tesla";
    // yugo.Price = 400;
    // Console.WriteLine(amc.Miles);

    //  MAX PRICE METHOD

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

    //  PERCENTAGE OFF METHOD

    // foreach(Car autos in Cars)
    // {
    //   autos.SalePrice(myPercentoff);
    //   Console.WriteLine("----------------------");
    //   Console.WriteLine("Our Cars are now " + myPercentoff + "% off");
    //   Console.WriteLine(autos.MakeModel);
    //   Console.WriteLine("$" + autos.Price);
    // }

    // SORTED LIST AND KEY/VALUE PAIR SORTING
    
    // SortedList<string, int> rallyCars = new SortedList<string, int>();
    //   rallyCars.Add(Cars[0].MakeModel, Cars[0].OffRoadAbility);
    //   rallyCars.Add(Cars[1].MakeModel, Cars[1].OffRoadAbility);
    //   rallyCars.Add(Cars[2].MakeModel, Cars[2].OffRoadAbility);
    //   rallyCars.Add(Cars[3].MakeModel, Cars[3].OffRoadAbility);
    //   foreach (KeyValuePair<string, int> car in rallyCars.OrderBy(key => key.Value))  
    //   {  
    //     Console.WriteLine("{0}, {1}", car.Key, car.Value);  
    //   }  
  }
}
}