using System;
using System.Linq;
using LaboratoryWork.Utils;

namespace LaboratoryWork
{
  internal class MainClass
  {
    private static double CustomSin(double input)
    {
      const double Precision = 1E-7;

      double result = input;
      double last = input;
      int exponent = 3;
      bool isNegative = true;

      while (Math.Abs(last) >= Precision)
      {
        last = (1 - Convert.ToInt32(isNegative)*2)*Math.Pow(input, exponent)/Enumerable.Range(1, exponent).Aggregate((first, second) => first*second);
        result += last;
        exponent += 2;
        isNegative = !isNegative;
      }

      return result;
    }

    private static void Main(string[] args)
    {
      var x = Base.ReadDouble("Please enter x variable value: ");
      Console.WriteLine($"{nameof(Math.Sin)} == {Math.Sin(x)} | {nameof(CustomSin)} == {CustomSin(x)}");
    }
  }
}
