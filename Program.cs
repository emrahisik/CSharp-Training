// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Console.WriteLine(Console.ReadLine());
      // Variables//

      // 1 byte
      // byte myByte = 255;
      // byte myLowestByte = 0;

      // sbyte mySignedByte = 127;
      // sbyte myLowestSignedByte = -128;

      // // 1 word (shortword) = 2 bytes
      // ushort myWord = 65535;
      // short mySignedWord = -32768;

      // // 1 long word = 4 bytes
      // int myInt = 2147483647;
      // int myLowestInt = -2147483648;

      // // 1 quadword/doubleword = 8 bytes
      // long myLong = -9223372036854775808;

      // // 4 bytes floating point numbers
      // float myFloat = 0.4f;
      // float mySecondFloat = 0.268687678f;

      // // 8 byte floating point number
      // double myDouble = 0.50000094909999;
      // double myExplicitDouble = 0.5d;

      // // 16 byte (128 byte) floating point number
      // decimal myDecimal = 0.7m;
      // decimal mySecondDecimal = 0.700000045438m;

      // Console.WriteLine(myFloat - mySecondFloat);
      // Console.WriteLine(myDouble - myExplicitDouble);
      // Console.WriteLine(myDecimal - mySecondDecimal);

      // // Strings
      // string myString = "Hell o World!";
      // Console.WriteLine(myString);

      // string myStringOfSymbols = "0987654321~!@#$%^&*()_+[];',./?><:|}{}";
      // Console.WriteLine(myStringOfSymbols);

      // // Boolean
      // bool myBool = true;

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