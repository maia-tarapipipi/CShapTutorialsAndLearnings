using System;
class Program 
{
  static void Main(string[] args)
    {
      string permission = "Admin|Manager";
      int level = 21;

      if (level > 55 && permission == "Admin|Manager") 
      {
        System.Console.WriteLine("Welcome, Super Admin user.");
      }
      else if (level >= 21 && level <= 55 && permission == "Admin|Manager")
      {
        System.Console.WriteLine("Welcome Admin user.");
      }
      else if (level >= 1 && level <= 20 &&  permission == "Admin|Manager") 
      {
        System.Console.WriteLine("You do not have sufficient privileges.");
      }
      else 
      {
        System.Console.WriteLine("You do not have sufficient privileges.");
      }



    }

}