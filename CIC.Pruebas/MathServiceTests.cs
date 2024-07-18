using CIC.Business;
using CIC.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace CIC.Pruebas
{
  public class MathServiceTests
  {
    [Fact]
    public void OperarDosNumerosTest_Suma()
    {
      //Arrange
      ResponseDto<double> suma = new();
      //Act
      suma = MathService.OperarDosNumeros("suma", 4, 8);
      //assert
      Assert.NotNull(suma);
      Assert.Equal(suma.Data, 12);
    }

    [Fact]
    public void OperarDosNumerosTest_Division_Cero()
    {
      //Arrange
      ResponseDto<double> division = new();
      //Assert
      Assert.NotNull(division);
      Assert.Throws<DivideByZeroException>(() => MathService.OperarDosNumeros("division", 100, 0));
    }

    [Fact]
    public void OperarDosNumeros_IsSuccessfull_False()
    {
      //Arrange
      ResponseDto<double> resta = new();
      //Act
      resta = MathService.OperarDosNumeros("resta", 5, 10);
      //Assert
      Assert.Equal(resta.Data, -5);
      Assert.Equal(resta.Errors, ["El resultado es negativo"]);
      Assert.Equal(resta.IsSuccessful, false);
    }


    [Fact]
    public void CompararNumeros_Numero1_MayorQue_NumeroDos()
    {
      //Arrange
      bool resultado;
      //Act
      resultado = MathService.CompararDosNumeros(10, 8);
      //Assert
      Assert.True(resultado);
    }

    [Fact]
    public void CompararNumeros_NumeroDos_MayorQue_NumeroUno()
    {
      bool resultado;
      resultado = MathService.CompararDosNumeros(8, 10);
      Assert.False(resultado);
    }


    [Theory(Skip ="No ejecutar esta prueba porque el método está incompleto")]
    [InlineData(10, 5, 2)]
    [InlineData(20,2, 10)]
    [InlineData(50, 5, 10)]
    public void DividirDosNumeros(double num1, double num2, double expected)
    {
      double division = 0;

      division = MathService.OperarDosNumeros("division", num1, num2).Data;
      Assert.Equal(expected, division);
    }

  }
}
