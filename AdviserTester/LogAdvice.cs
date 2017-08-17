using ArxOne.MrAdvice.Advice;
using NLog;
using System;

namespace AdviserTester
{
  public class LogAdvice : Attribute, IMethodAdvice, IMethodInfoAdvice
  {
    private readonly Logger _logger;

    public LogAdvice()
    {
      _logger = LogManager.GetLogger("*");
    }

    public void Advise(MethodAdviceContext context)
    {
      var contextMessage = $"Context:{context.Target}, Method:{context.TargetMethod.Name}, Type:{context.TargetType.Name}, args:{context.Arguments.Count}";
      _logger.Log(LogLevel.Info, contextMessage);

      context.Proceed(); // this calls the original method
      Console.WriteLine($"returns: {context.ReturnValue}");
    }

    public void Advise(MethodInfoAdviceContext context)
    {
      _logger.Log(LogLevel.Info, $"Method starting: {context.TargetMethod.Name}");
    }
  }
}
