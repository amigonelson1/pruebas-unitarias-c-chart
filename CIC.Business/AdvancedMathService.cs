using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIC.Business
{
  public class AdvancedMathService : IAdvancedMathService
  {
    private readonly IAdvancedMathService _advancedMathService;

    public AdvancedMathService(IAdvancedMathService advancedMathService)
    {
      _advancedMathService = advancedMathService;
    }

    public double CalculateRaisedNumber(double num1, double num2)
    {
      return Math.Pow(num1, num2);
    }

    public double CalculateSquareRoot(double num1)
    {
      return Math.Sqrt(num1);
    }
  }
}
