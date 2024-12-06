using System;
// using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TurnBasedGame
{
    class Program
    {
        static void Main(string[] args)
        {            
            Random random = new Random();
            int continueChoice = 1;


            do
            {

                //Healthpoint  Stats
                int playerHp = 100;
                int enemyHp = 100;

                Console.WriteLine("======== TBG ========");

                while (playerHp > 0 && enemyHp > 0)
                {
                    //Damage Stats
                    int attack = random.Next(10,20);

                    //Heal
                    int heal = random.Next(1,20);

                    Console.WriteLine("\n===== Player Turn =====\n HP: " + playerHp + "\t Enemy HP: "+ enemyHp);
                    Console.WriteLine("Choice: 1 - Attack \t 2 - Heal");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        Console.WriteLine("Player Turn\nAttacking...\ndealt " + attack + " damage");
                        enemyHp = enemyHp - attack;
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Healing for " + heal + " healthpoints");
                        playerHp = playerHp + heal;
                    }


                    if (playerHp <= 0)
                    {
                        Console.WriteLine("\nYou Lose");
                        break;
                    }
                    else if (enemyHp <= 0)
                    {
                        Console.WriteLine("\nYou Win");
                        break;
                    }

                    attack = random.Next(10,20);

                    Console.WriteLine("\n===== Enemy Turn =====\nEnemy dealt " + attack + "damage\n");
                    playerHp = playerHp - attack;
            
                }

                Console.WriteLine("\nWould You Like to play again? [1 - continue // 2 - end ]\nEnter Choice: ");
                continueChoice = Convert.ToInt32(Console.ReadLine());
            }
            while (continueChoice == 1);


        }
    }
    
}




