using System;
using System.Linq;
using System.Globalization;
using LaboratoryWork.Utils;

namespace LaboratoryWork
{
  internal static class MainClass
  {
    private static double CustomSin(double input)
    {
      const double Precision = 1E-7;

      double result = 0;
      double last = 0;
      double poweredInput = input;
      int exponent = 1;
      int sign = 1;
      long factorial = 1;

      do
      {
        last = poweredInput/factorial;
        result += sign*last;
        sign = -sign;
        exponent += 2;
        factorial *= (long)(exponent - 1)*exponent;
        poweredInput *= Math.Pow(input, 2);
      } while (Math.Abs(last) >= Precision);

      return result;
    }

    private static void Main()
    {
      var x = Base.ReadDouble("Please enter x variable value: ");
      Console.WriteLine(string.Format(CultureInfo.CurrentCulture, "{0} == {1} | {2} == {3}", nameof(Math.Sin), Math.Sin(x), nameof(CustomSin), CustomSin(x)));
    }
  }
}
