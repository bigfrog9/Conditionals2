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

            System.ConsoleKey weaponChar = Console.ReadKey(true).Key;
            
            if (weaponChar == ConsoleKey.D1)
            {
                ChangeWeapon(0);
                ShowHUD();
            }
            else if (weaponChar == ConsoleKey.D2)
            {
                ChangeWeapon(1);
                ShowHUD();
            }
            
            else if (weaponChar == ConsoleKey.D3)
            {
                ChangeWeapon(2);
                ShowHUD();
            }

            else if (weaponChar == ConsoleKey.D4)
            {
                ChangeWeapon(3);
                ShowHUD();
            }

            else if (weaponChar == ConsoleKey.D5)
            {
                ChangeWeapon(4);
                ShowHUD();
            }

            else if (weaponChar == ConsoleKey.D6)
            {
                ChangeWeapon(5);
                ShowHUD();
            }

            Console.ReadKey(true);
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
