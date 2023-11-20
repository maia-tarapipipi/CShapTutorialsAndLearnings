// See https://aka.ms/new-console-template for more information

using System;

class Program
{
  static void Main() 
  {
    
    // Takes a string, reverses it and counts how many times 'o' appears
    
    string str = "The quick brown fox jumps over the lazy dog.";

    char[] charMessage = str.ToCharArray();
    Array.Reverse(charMessage);
    
    int charCount = 0;

    foreach (char i in charMessage) 
    {
      if (i == 'o') { charCount++; } 
    }

    string new_message = new String(charMessage);

    Console.WriteLine(new_message);
    Console.WriteLine($"'o' appears {charCount} times.");
  } 
  
}

