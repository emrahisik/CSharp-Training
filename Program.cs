// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] intsToCompress = new int[]{10,15,20,25,30,35};
      IEnumerable<int> comp = intsToCompress;
      Console.WriteLine(comp.LongCount()); // Length of Ienum

      int sum = 0;
      DateTime f = DateTime.Now;
      for(int i=0; i<intsToCompress.Length; i++)
      {
        sum+=intsToCompress[i];
      }

      Console.WriteLine(DateTime.Now-f);


      // Using IEnumerable with foreach

      sum = 0;
      f = DateTime.Now;
      foreach (var num in comp)
      {
        sum+=num;
      }
      Console.WriteLine(DateTime.Now-f);
      // Console.WriteLine(sum);
    }
  }
}