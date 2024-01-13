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

      Console.WriteLine($"Total time spent in microseconds {(DateTime.Now - startTime).TotalMicroseconds}");


      // Using IEnumerable with foreach

      sum = 0;
      startTime = DateTime.Now;
      foreach (var num in numbarsArrayEnumerated
      )
      {
        sum += num;
      }
      Console.WriteLine($"Total time spent in microseconds {(DateTime.Now - startTime).TotalMicroseconds}");
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
      Console.WriteLine($"Total time spent in microseconds {(DateTime.Now - startTime).TotalMicroseconds}");


      sum = 0;
      startTime = DateTime.Now;
      index = 0;
      do
      {
        sum += numbersArray[index];
        Console.WriteLine(sum);
        index++;
      }
      while (index < numbersArray.Length); // Not a good example though
      // do{}while() loop is more for the scenarios where do code block is required to run at least one time before comparison in while statement
      Console.WriteLine($"Total time spent in microseconds {(DateTime.Now - startTime).TotalMicroseconds}");


      // Array built in method for sum
      startTime = DateTime.Now;
      sum = numbersArray.Sum();
      Console.WriteLine(sum);
      Console.WriteLine($"Total time spent in microseconds {(DateTime.Now - startTime).TotalMicroseconds}");
    }
  }
}