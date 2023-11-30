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
      
      /*
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
      */

      // --- CODE PROJECT 3: Processing strings in an array ---

      // mandatory code from exercise
    string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
    // int stringsCount = myStrings.Length;

    string myString = "";
    int periodLocation = 0;

    for (int i = 0; i < myStrings.Length; i++)
    {
      myString = myStrings[i];
      periodLocation = myString.IndexOf(".");
          

      string mySentence;

      // extract sentences from each string and display them one at a time
      while (periodLocation != -1)
        {
          // first sentence is the string value to the left of the period location
          mySentence = myString.Remove(periodLocation);

          // the remainder of myString is the string value to the right of the location
          myString = myString.Substring(periodLocation + 1);

          // remove any leading white-space from myString
          myString = myString.TrimStart();

          // update the comma location and increment the counter
          periodLocation = myString.IndexOf(".");

          Console.WriteLine(mySentence);
        }

      mySentence = myString.Trim();
      Console.WriteLine(mySentence);
    }
    

     
    }     
}