using System;
class Program 
{
  static void Main(string[] args)
    {
      // --- CODE PROJECT 1: Validates Integer Input ---
      /*
      string? readResult;
      bool validEntry = false;

   

      System.Console.WriteLine("Please submit an integer between 5 and 10");
      do
      {
        readResult = System.Console.ReadLine();
        int integer = 0;
        bool validNumber = false;
        if (validNumber = int.TryParse(readResult, out integer)) 
        {
        if (integer > 5 && integer < 10) 
        { 
          validEntry = true;
        } else 
        {
          System.Console.WriteLine("The integer you have submitted is incorrect, please submit a valid integer");    
        }
      
        } else
        {
          System.Console.WriteLine("Please submit a valid integer between 5 and 10");
        };
     
      } while (validEntry == false);

      System.Console.WriteLine($"Your input of ({readResult}) has been accepted");
      */

      // --- CODE PROJECT 2: Validates String Input --- 

      string? readResult;
      bool permissions = false;
      System.Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

      do
      {
        readResult = Console.ReadLine();
        string validResult = readResult.Trim().ToLower();
        if (validResult == "administrator" || validResult  == "manager" || validResult == "user")
        {
          permissions = true;
          System.Console.WriteLine($"Your input value ({validResult}) has been accepted.");
        } else
        {
        System.Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role (Administrator, Manager, or User)");
        }
      } while (permissions == false);

    }     
}