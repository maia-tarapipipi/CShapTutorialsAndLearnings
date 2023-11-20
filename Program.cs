// See https://aka.ms/new-console-template for more information

using System;

class Program
{
  static void Main(string[] args) 
  {
     Random random = new Random();
    int daysUntilExpiration = random.Next(12);
    int discountPercentage = 0;

    if (daysUntilExpiration < 10) 
    {
      System.Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
    else if (daysUntilExpiration < 5) 
    { 
      System.Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save 10%!");
    }
    else if (daysUntilExpiration == 1)
    { 
      System.Console.WriteLine("Your subscription expires within a day! Renew now and save 20%!");
    }
    else if (daysUntilExpiration < 1)
    {
      System.Console.WriteLine("Your subscription has expired.");
    }

  } 
  
}

