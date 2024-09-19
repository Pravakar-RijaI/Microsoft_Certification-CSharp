using System;

namespace CSharpFoundation
{
    internal class Game
    {
        public static void Main()
        {
            Random life = new Random();
            int playerHealth = 10;
            int monsterHealth = 10;
            Console.WriteLine("------------------ WELCOME TO ROLE BATTLE GAME ------------------------\n");
            Console.WriteLine($"Player's Health: {playerHealth}");
            Console.WriteLine($"Monster's Health: {monsterHealth}");
            
            Console.WriteLine("\n********************* FIGHT STARTS ***************************\n");
            
            do
            {
                Console.WriteLine($"xxxxxxxxxxxxxxxxxxxxxxx PLAYER ATTACKS xxxxxxxxxxxxxxxxxxxxxxx");
                int playerAttack = life.Next(1,11);
                Console.WriteLine($"{playerAttack} XP");
                monsterHealth -= playerAttack;
                Console.WriteLine($"Player's Health: {playerHealth}");
                Console.WriteLine($"Monster's Health: {monsterHealth}");
                
                if(monsterHealth <= 0)
                    continue;
                
                Console.WriteLine($"xxxxxxxxxxxxxxxxxxxxxxx MONSTER ATTACKS xxxxxxxxxxxxxxxxxxxxxxx");
                int monsterAttack = life.Next(1,11);
                Console.WriteLine($"{monsterAttack} XP");
                playerHealth -= monsterAttack;
                Console.WriteLine($"Player's Health: {playerHealth}");
                Console.WriteLine($"Monster's Health: {monsterHealth}");

            }while(playerHealth > 0 && monsterHealth > 0);
            
             Console.WriteLine("\n********************* FIGHT ENDS ***************************");
             if(playerHealth > monsterHealth)
                Console.WriteLine("\nooooooooooooooooooooo Player Wins ooooooooooooooooooooooooo");
            else
                Console.WriteLine("\noooooooooooooooooooooo Monster Wins oooooooooooooooooooooooo");
            Console.WriteLine("\n--------------------------- GAME OVER ---------------------------------");
        }
    }
}