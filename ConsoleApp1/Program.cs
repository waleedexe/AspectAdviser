using AdviserTester;
using System;

namespace ConsoleApp1
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      var x = new Startup();
      var result = x.DoubleAsString(3);
      Console.WriteLine($"Double of {3} is {result}");

      Console.ReadLine();
    }
  }
}