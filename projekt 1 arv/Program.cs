using System;


namespace Program
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

      Console.Write("How many times? ");
      int number = int.Parse(Console.ReadLine());

      for (int i = 0; i < number; i++)
        foreach (string car in cars)
          Console.WriteLine(car);
    }
  }
}