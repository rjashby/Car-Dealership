using System;

namespace Dealership.Models {

  public class Car
{
    // Public auto-implemented properties
    public string MakeModel { get; set; }
    public int Year { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public int OffRoadAbility {get; set;}

    // Constructor
    public Car(string makeModel, int year, int price, int miles, int offRoadAbility) 
    {
        Year = year;
        MakeModel = makeModel;
        Price = price;
        Miles = miles;
        OffRoadAbility = offRoadAbility;
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public void SalePrice(int myReduceAmount)
    {
      Price = Price - ((Price * myReduceAmount) / 100); 
    }
    public void YearBasedPrice() {
        Price = Convert.ToInt32(Year * .75);
    }
  }

}