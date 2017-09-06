using ArxOne.MrAdvice.Advice;
using NLog;
using System;

namespace AdviserTester
{
  public class PersonAdvice : Attribute, IMethodAdvice, IMethodInfoAdvice
  {
    private readonly Logger _logger;

    public PersonAdvice()
    {
      _logger = LogManager.GetLogger("*");
    }

    public void Advise(MethodAdviceContext context)
    {
      var contextMessage = $"Context:{context.Target}, Is a person Advice";
      _logger.Log(LogLevel.Warn, contextMessage);

      context.Proceed(); // this calls the original method
    }

    public void Advise(MethodInfoAdviceContext context)
    {
      _logger.Log(LogLevel.Info, $"Method {context.TargetMethod.Name} is part of {context.TargetMethod.DeclaringType.Name}");
    }
  }
}
