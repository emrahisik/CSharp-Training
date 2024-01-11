// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int firstInt = 5;
      int secondInt = 10;
      int resOne = firstInt++;
      Console.WriteLine(firstInt);
      int resTwo = ++firstInt;
      Console.WriteLine(resOne);
      Console.WriteLine(resTwo);

      Console.WriteLine(Math.Pow(5,4));
      Console.WriteLine(Math.Sqrt(5)==Math.Pow(5,0.5));
      Console.WriteLine(Math.Max(34,4));

      string test = "test";
      Console.WriteLine(test);

      test += " concatinate";
      Console.WriteLine(test);

      string quote = " \"third\""; // Backslash to escape from quote error
      test += quote;
      Console.WriteLine(test);

      string[] testArray = test.Split(" ");
      for (int i = 0; i < testArray.Length; i++)
      {
        Console.WriteLine($"{testArray[i]}");
      }
      Console.WriteLine(firstInt.Equals(secondInt)); // returns true || flase 
      Console.WriteLine(firstInt.CompareTo(secondInt)); // returns 0 (equal)|| 1 (greater than) || -1 (less than)
      //Shoerthand
      Console.WriteLine(firstInt == secondInt);
      Console.WriteLine(firstInt < secondInt);
    }
  }
}