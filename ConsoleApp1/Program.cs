using AdviserTester;
using System;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      //new Sampler().SamplerTest();

      var x = new Startup();
      var result = x.DoubleAsString(3);
      Console.WriteLine($"Double of {3} is {result}");

      Console.ReadLine();
    }
  }
}
