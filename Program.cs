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
      Console.WriteLine(numbarsArrayEnumerated
      .LongCount()); // Length of Ienum

      int sum = 0;
      DateTime startTime = DateTime.Now;
      for (int i = 0; i < numbersArray.Length; i++)
      {
        sum += numbersArray[i];
      }

      Console.WriteLine(DateTime.Now - startTime);


      // Using IEnumerable with foreach

      sum = 0;
      startTime = DateTime.Now;
      foreach (var num in numbarsArrayEnumerated
      )
      {
        sum += num;
      }
      Console.WriteLine(DateTime.Now - startTime);
      Console.WriteLine(sum);


      sum = 0;
      startTime = DateTime.Now;
      int index = 0;
      while (index < numbersArray.Length)
      {
        sum += numbersArray[index];
        Console.WriteLine(sum);
        index++;
      }
      Console.WriteLine(DateTime.Now - startTime);

    }
  }
}