using System;

namespace LaboratoryWork.Utils
{
  public static class Base
  {
    public static double ReadDouble(string prompt = "")
    {
      Console.Write(prompt);
      return double.Parse(Console.ReadLine());
    }
  }
}