using System;
class Program 
{
  static void Main(string[] args)
    {
        Random coin = new Random();
        int flip = coin.Next(0, 10);

        System.Console.WriteLine($"{(flip % 2 == 0 ? $"heads {flip}" : $"tails{flip}")}");
    }

}