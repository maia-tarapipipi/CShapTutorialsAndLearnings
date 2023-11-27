using System;
class Program 
{
  static void Main(string[] args)
    {
      // to read from the console the variable type must use a nullable string type as it can be both null and have value
      string? readResult;
      Console.WriteLine("Enter a string:");
      bool validEntry = false;

      do
      {
        readResult = Console.ReadLine();
        if (readResult != null)
        {
          if (readResult.Length >= 3)
          {
            validEntry = true; 
            System.Console.WriteLine("You have typed a valid entry");
          }
          else 
          {
            validEntry = false;
            System.Console.WriteLine("Your input is invalid, please try again");
          }
        }
      } while (readResult == null);

    }     
}