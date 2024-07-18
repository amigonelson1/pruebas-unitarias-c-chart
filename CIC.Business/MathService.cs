using CIC.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIC.Business
{
  public class MathService
  {
    public static ResponseDto<double> OperarDosNumeros(string operation, double a, double b)
    {
      double result = 0;
      ResponseDto<double> rta = new ResponseDto<double> { Data = 0, Errors = [], IsSuccessful = true };
      if(a == null || b == null) return new() { Data=0, Errors = ["Los valores no pueden ser nulos"], IsSuccessful = false };
      switch (operation.ToUpper().Trim())
      {
        case "SUMA":
          result= a + b;
          break;
        case "RESTA":
          result = a - b;
          if(result < 0) return new() { Data=result, Errors = ["El resultado es negativo"], IsSuccessful = false };
          break;
        case "MULTIPLICACION":
          result = a * b;
          break;
        case "DIVISION":
          if(b == 0) throw new DivideByZeroException();
          result = a / b;
          break;
      }
      rta = new ResponseDto<double> { Data = result, Errors = [], IsSuccessful = true };
      return rta;
    }

    public static bool CompararDosNumeros(double num1, double num2)
    {
      if (num1 > num2) return true;
      else return false;
    }

  }


}
