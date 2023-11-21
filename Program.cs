using System;
class Program 
{
  static void Main(string[] args)
    {
        Random coin = new Random();
        // int flip = coin.Next(0, 800);

        System.Console.WriteLine((coin.Next(0, 100) % 2 == 0 ? "heads" : "tails"));
    }

}