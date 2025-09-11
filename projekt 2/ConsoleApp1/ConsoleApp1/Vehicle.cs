using System;

namespace MyApplication
{
  class Vehicle  // bas klassen
  {
    public string brand = "Ford";  // veichle fält som håller i värdet "Ford"
    public void honk()   // Vehicle metod vilket skriver ut "Tuut, tuut!"
    {
      Console.WriteLine("Tuut, tuut!");
    }
  }
}
