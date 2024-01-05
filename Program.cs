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
      Console.WriteLine(firstInt.Equals(secondInt)); // returns true || flase 
      Console.WriteLine(firstInt.CompareTo(secondInt)); // returns 0 (equal)|| 1 (greater than) || -1 (less than)
      //Shoerthand
      Console.WriteLine(firstInt == secondInt);
      Console.WriteLine(firstInt < secondInt);

    }
  }
}