using System;
class Program 
{
  static void Main(string[] args)
    {
      // do while / while loop
      string? readResult;
      bool validEntry = false;

   

      System.Console.WriteLine("Please submit an integer between 5 and 10");
      do
      {
        readResult = System.Console.ReadLine();
        int integer = 0;
        bool validNumber = false;
        validNumber = int.TryParse(readResult, out integer);

        if (integer > 5 && integer < 10) 
        { 
          validEntry = true;
        } else 
        {
          System.Console.WriteLine("The integer you have submitted is incorrect please submit a valid integer");    
        }
      
      } while (validEntry == false);

      System.Console.WriteLine("The integer you have submitted has been accepted");
    }     
}