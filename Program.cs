// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] numbersArray = new int[] { 10, 15, 20, 25, 30, 35 };
      IEnumerable<int> numbarsArrayEnumerated
       = numbersArray;

      Console.WriteLine(GetSum(numbersArray));
    }

    
    static private int GetSum(int[] array)
    {
      int sum = 0;
      foreach (var num in array)
      {
        sum += num;
      }
      return sum;
    }
  }
}