using System;

namespace LaboratoryWork.Utils
{
  public static class Base
  {
    public static double ReadDouble(string prompt = "")
    {
      Console.Write(prompt);
      double result = default(double);
      double.TryParse(Console.ReadLine(), out result);
      return result;
    }
  }
}