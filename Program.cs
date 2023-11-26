using System;
class Program 
{
  static void Main(string[] args)
    {
   
   for (int i = 1; i < 30; i++)
   {
    if (i % 15 == 0)
    System.Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 5 == 0) 
    System.Console.WriteLine($"{i} - Buzz");
    else if (i % 3 == 0) 
    System.Console.WriteLine($"{i} - Fizz");
    else 
    System.Console.WriteLine(i);
   };
    }

}