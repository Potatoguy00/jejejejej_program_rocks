using System;

namespace MyApplication
{
  class Program
  { 
    static void Main(string[] args)
    {
      // skapar ett mycar object
      Car myCar = new Car();
      Truck myTruck = new Truck();
      // kallar på honk() (metoden från veichle klassen)

      myTruck.honk();
      myCar.honk();
      

      // visa värdet på fältet "brand field" (från veichle klassen) och värdet av "modelName" från "Car" klassen
      Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
  }
}