using ArxOne.MrAdvice.Advice;
using NLog;
using System;
using System.Linq;

namespace AdviserTester
{
  public class LogAdvice : Attribute, IMethodAdvice
  {
    private readonly Logger _logger;

    public LogAdvice()
    {
      _logger = LogManager.GetLogger("*");
    }

    public void Advise(MethodAdviceContext context)
    {
      var args = context.Arguments.Select(x => x.ToString());
      var methodInfo = $"Context:{context.Target}, Method:{context.TargetMethod.Name}.";
      _logger.Log(LogLevel.Info, $"{methodInfo} STARTED. args:{args.Count()} [{string.Join(",", args)}].");

      context.Proceed(); // this calls the original method

      _logger.Log(LogLevel.Info, $"{methodInfo} ENDED." + (context.HasReturnValue ? $" Returns:{context.ReturnValue}." : ""));
    }
  }
}