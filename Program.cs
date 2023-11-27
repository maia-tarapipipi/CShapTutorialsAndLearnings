using System;
class Program 
{
  static void Main(string[] args)
    {
      
      int heroHealth = 10;
      int monsterHealth = 10;
      Random attack = new Random();
       
     do
     {
      if (monsterHealth > 0)
      {
        int damage = attack.Next(1, 10);
        monsterHealth = monsterHealth - (int)damage;
        System.Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.");
        if (monsterHealth <= 0) 
        {
        System.Console.WriteLine("Hero Wins!");
        }
      };
       if (monsterHealth > 0)
      {
      int damage = attack.Next(1, 10);
      heroHealth = heroHealth - damage;
      System.Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health.");  
      if (heroHealth <= 0 ){
      System.Console.WriteLine("Monster Wins!");
      }
      };
      
     } while (monsterHealth > 0 && heroHealth > 0);



      
      

    }

}