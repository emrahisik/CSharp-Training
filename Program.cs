// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Arrays
      string[] myGroceryArray = new string[2];
      myGroceryArray[0] = "Broccoli";
      Console.WriteLine(myGroceryArray[0]);
      Console.WriteLine(myGroceryArray[1]);

      string[] myFruits = ["Apples", "Pears"]; // Old version => string[] myFruits = {"Apples", "Pears"};
      // myFruits[2] = "";
      Console.WriteLine(myFruits[0]);
      Console.WriteLine(myFruits[1]);
      Console.WriteLine(myFruits.GetType());
      // Console.WriteLine(myFruits[2]);

      // Lists
      List<string> myGroceryList = ["Asparagus", "Milk", "Eggs"]; // Old version => List<string> myList = new List<string>()
      Console.WriteLine($"{myGroceryList[0]}, {myGroceryList[2]}");
      myGroceryList.Add("Tomatoes");
      Console.WriteLine($"{myGroceryList[0]}, {myGroceryList[3]}");

      // IEnumerable
      IEnumerable<string> myGroceryIEnum = myGroceryList; 
      Console.WriteLine(myGroceryIEnum.Last());

      // 2D array
      string[,] myTwoDimentionalArray = {{"apples", "pears", "bananas"},{"eggs", "milk", "cheese"}};
      Console.WriteLine (myTwoDimentionalArray[1,2]);

      // Dictionary
      Dictionary<string,string[]> groceryMap = new(){{"Diary", new string[]{"Cheeese", "Milk", "Eggs"}}}; // Old version = new Dictionary<string, string[]>(){{"Diary", new string[]{"Cheeese", "Milk"}}};
      Console.WriteLine(groceryMap["Diary"][2]);
    }
  }
}