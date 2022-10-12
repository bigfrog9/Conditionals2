using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static string equip;
        static int health;
        static string status;
        
        static void Main(string[] args)
        {
            health = 100;
            ShowHUD();

        }

        static void ShowHUD()
        {

            if (health == 100)
            {
                status = "Top of your game";
            }

            if (health >= 90 && health < 100)
            {
                status = "Not even hurt";
            }

            if (health >= 75 && health < 90)
            {
                status = "Scratched up";
            }

            if (health >= 50 && health < 75)
            {
                status = "Gushing Blood";
            }

            if (health >= 25 && health < 50)
            {
                status = "Seeing red";
            }

            if (health >= 15 && health < 25)
            {
                status = "Life flashing before eyes";
            }

            if (health > 0 && health < 15)
            {
                status = "Not quite dead";
            }

            if (health == 0)
            {
                status = "Quite dead";
            }
            
            Console.WriteLine("--------");
            Console.WriteLine("Health: " + health);
            Console.WriteLine(""+"");
            Console.WriteLine("Status: " + status);
            Console.WriteLine(""+"");
            Console.WriteLine("Weapon: " + equip);
            Console.WriteLine("--------");

            Console.ReadKey(true);
        }

        static void ChangeWeapon(int weapon)
        {
            if (weapon == 0)
            {
                equip = "Fists";
            }

            if (weapon == 1)
            {
                equip = "Wood plank";
            }

            if (weapon == 2)
            {
                equip = "Knife";
            }

            if (weapon == 3)
            {
                equip = "Machete";
            }

            if (weapon == 4)
            {
                equip = "Broadsword";
            }

            if (weapon == 5)
            {
                equip = "Chainsaw";
            }
        }
       
    }
}
