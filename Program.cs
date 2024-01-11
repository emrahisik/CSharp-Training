// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using Microsoft.VisualBasic;
namespace HelloWorld
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int firstInt = 5;
      int secondInt = 10;
      // Console.WriteLine(firstInt.Equals(secondInt)); // returns true || flase 
      // Console.WriteLine(firstInt.CompareTo(secondInt)); // returns 0 (equal)|| 1 (greater than) || -1 (less than)
      // //Shoerthand
      // Console.WriteLine(firstInt == secondInt);
      // Console.WriteLine(firstInt < secondInt);
      
      if(firstInt > secondInt)
      {
        Console.WriteLine($"{firstInt} is greater than {secondInt}");
      }
      else if(firstInt == secondInt)
      {
        Console.WriteLine($"{firstInt} is equal to {secondInt}");
      }
      else
      {
        Console.WriteLine($"{firstInt} is smaller than {secondInt}");
      }

      switch(DateAndTime.Today.DayOfWeek)
      {
        case DayOfWeek.Saturday:
        case DayOfWeek.Sunday:
          Console.WriteLine("It is weekend");
          break;
        default:
          Console.WriteLine("It is a weekday".ToLower());
          break;
      }
      

      // Shorthand
      string comparison = firstInt > secondInt ? "greater than" : firstInt < secondInt ? "smaller than" : "equal to";
      Console.WriteLine($"{firstInt} is {comparison} {secondInt}");

    }
  }
}