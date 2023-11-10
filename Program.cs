// See https://aka.ms/new-console-template for more information

using System;

class Program {
  static void Main(string[] args) 
  {
    Random dice = new Random();
    int roll = dice.Next(1, 7);
    Console.WriteLine(roll);

  }
  }

