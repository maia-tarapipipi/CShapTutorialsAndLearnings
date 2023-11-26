using System;
class Program 
{
  static void Main(string[] args)
    {
 // do while 
 
Random random = new Random();
int current = random.Next(1, 11);

/*
do
{
 // will execute at least once -> large number while the code within the "while" code block is true
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

// positioning the boolean before the code block makes the block act as a gate for the expression to only allow the flow of execution to enter if the bool expression evaluates to true 
// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

// Continue is the important part of the code block ensuring that the statement transfers execution to the end of the current iteration.
do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

    }

}