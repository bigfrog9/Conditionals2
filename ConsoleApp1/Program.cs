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
        static int Maxhealth;
        static int Dead;


        static void Main(string[] args)
        {
            Maxhealth = 100;
            health = 100;
            Dead = 0;
            ChangeWeapon(0);
            ShowHUD();

            Console.WriteLine("Press Any Key to Apply damage to the player");

            Console.ReadKey(true);
            Takedamage(10);

            ShowHUD();

            Console.WriteLine("Okay now press any key to change the weapon, and we'll apply some more damage");

            Console.ReadKey(true);

            ChangeWeapon(1);

            Takedamage(10);

            ShowHUD();

            Console.WriteLine("Press any key to cycle to the next weapon and take some more damage");

            Console.ReadKey(true);

            ChangeWeapon(2);

            Takedamage(10);

            ShowHUD();

            Console.WriteLine("Press any to key to cycle next weapon etc.");

            Console.ReadKey(true);

            ChangeWeapon(3);

            Takedamage(10);

            ShowHUD();

            Console.WriteLine("Just a couple more times");

            Console.ReadKey(true);

            ChangeWeapon(4);

            Takedamage(10);

            ShowHUD();

            Console.WriteLine("Once more to see the last weapon");

            Console.ReadKey(true);

            ChangeWeapon(5);

            Takedamage(10);

            ShowHUD();

            Console.WriteLine("Now, press any key to take an incredible amount of damage");

            Console.ReadKey(true);

            Takedamage(80);

            ShowHUD();

            Console.WriteLine("Press any key to gain back some health");

            Console.ReadKey(true);

            Heal(30);

            ShowHUD();

            Console.WriteLine("Good job! You can press any key to close the game");

            Console.ReadKey(true);

            //I'm not including this in the code but I don't want to forget how to do this so I'm keeping it here
            //System.ConsoleKey weaponChar = Console.ReadKey(true).Key;

            //if (weaponChar == ConsoleKey.D1)
            //{
            //ChangeWeapon(0);
            //ShowHUD();
            //}

        }

        static void ShowHUD()
        {
            
            if (health == 100)
            {
                status = "Top of your game";
            }

            else if (health >= 90 && health < 100)
            {
                status = "Not even hurt";
            }

            else if (health >= 75 && health < 90)
            {
                status = "Scratched up";
            }

            else if (health >= 50 && health < 75)
            {
                status = "Gushing Blood";
            }

            else if (health >= 25 && health < 50)
            {
                status = "Seeing red";
            }

            else if (health >= 15 && health < 25)
            {
                status = "Life flashing before eyes";
            }

            else if (health > 0 && health < 15)
            {
                status = "Not quite dead";
            }

            else if (health == 0)
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

        }

        static void ChangeWeapon(int weapon)
        {
            if (weapon == 0)
            {
                equip = "Fists";
            }

            else if (weapon == 1)
            {
                equip = "Wood plank";
            }

            else if (weapon == 2)
            {
                equip = "Knife";
            }

            else if (weapon == 3)
            {
                equip = "Machete";
            }

            else if (weapon == 4)
            {
                equip = "Broadsword";
            }

            else if (weapon == 5)
            {
                equip = "Chainsaw";
            }
        }

        static void Heal(int hp)
        {
            health = health + hp;

            if (health > 100)
            {
                health = Maxhealth;
            }

            if (health < 0)
            {
                health = Dead;
            }

        }

        static void Takedamage(int damage)
        {
            health = health - damage;

            if (health > 100)
            {
                health = Maxhealth;
            }

            if (health < 0)
            {
                health = Dead;
            }

            

        }

    }
}
