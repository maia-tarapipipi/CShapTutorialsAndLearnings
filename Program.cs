using System;
class Program 
{
  static void Main(string[] args)
    {
     bool flag = true;
int value1 = 5;

if (value1 > 0)
{
    int value2 = 6;
    value1 = value1 + value2;

}
Console.WriteLine("Outside of code block: " + value1);
    }

}