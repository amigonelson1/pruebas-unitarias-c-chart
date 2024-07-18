using CIC.Business;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIC.Pruebas
{
  public class AdvancedMathServiceTests
  {
    [Fact]
   public void CalculateRaisedNumberTest()
    {
      var mockAdvancedMathService = new Mock<IAdvancedMathService>();
      var advancedMathService = new AdvancedMathService(mockAdvancedMathService.Object);

      double result = advancedMathService.CalculateRaisedNumber(5, 2);
      Assert.Equal(25, result);
    }
  }
}
