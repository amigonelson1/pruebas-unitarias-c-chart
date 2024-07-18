using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIC.Business
{
  public interface IAdvancedMathService
  {
    public double CalculateRaisedNumber(double num1, double num2);
    public double CalculateSquareRoot(double num1);
  }
}