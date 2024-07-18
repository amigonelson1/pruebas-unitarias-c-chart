using CIC.Business;
using CIC.Core;

Console.WriteLine("Ingrese la operación que desea realizar");
string name =  Console.ReadLine()!;

Console.WriteLine("Ingrese el primer numero");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero");
double num2 = Convert.ToDouble(Console.ReadLine());

ResponseDto<double> result = MathService.OperarDosNumeros(name, num1, num2);

Console.WriteLine(result.Data);


