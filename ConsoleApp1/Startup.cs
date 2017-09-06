using AdviserTester;

namespace ConsoleApp1
{
  [LogAdvice]
  public class Startup
  {
    public string DoubleAsString(int n)
    {
      return (n * 2).ToString();
    }
  }
}