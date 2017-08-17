using AdviserTester;

namespace ConsoleApp1
{
  public class Startup
  {
    [LogAdvice]
    public string DoubleAsString(int n)
    {
      return (n*2).ToString();
    }
  }
}
