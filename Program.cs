// See https://aka.ms/new-console-template for more information

using System;

class Program
{
  static void Main() 
  {
    string[] fraudulentOrderID = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

    foreach (string item in fraudulentOrderID)
    {
      if (item.StartsWith("B"))
      {
        Console.WriteLine(item);
      }
    };

  } 
  
}

