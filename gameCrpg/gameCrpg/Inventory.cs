using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace gameCrpg
{
    public class Inventory
    {
        public int Coins { set; get; }
        public int RawMeat { set; get; }
        public int Steak { set; get; }
        public int HealthPotion { set; get; }

        public Inventory(int _Coins, int _RawMeat, int _Steak, int _HealthPotion)
        {
            Coins = _Coins;
            RawMeat = _RawMeat;
            Steak = _Steak;
            HealthPotion = _HealthPotion;
        }

        public void Open(Cocona cocona, Inventory inventory)
        {
            Console.WriteLine();
            Console.WriteLine($"У вас есть {Coins} монет, {RawMeat} сырого мяса, {Steak} приготовленного мяса, {HealthPotion} зелья лечения");
            Console.WriteLine();
            Console.WriteLine("Что хотите применить?");
            Console.WriteLine();
            Console.WriteLine("1. Сырое мясо (30ХП)");
            Console.WriteLine("2. Приготовленное мясо (60ХП)");
            Console.WriteLine("3. Зелье лечения (MAКС ХП)");
            Console.WriteLine("9. Выйти из инвентаря");
            Console.WriteLine();
            string ans = Console.ReadLine();
            switch (ans)
            {
                case "1":
                    if (inventory.RawMeat > 0)
                    {
                        cocona.Heal("R");
                        inventory.RawMeat--;
                        Console.WriteLine($"ХП - {cocona.Health}");
                    }
                    else
                        Console.WriteLine("Недостаточно сырого мяса");
                    break;
                case "2":
                    if (inventory.Steak > 0)
                    {
                        cocona.Heal("S");
                        inventory.Steak--;
                        Console.WriteLine($"ХП - {cocona.Health}");
                    }
                    else
                        Console.WriteLine("Недостаточно приготовленного мяса");
                    break;
                case "3":
                    if (inventory.HealthPotion > 0)
                    {
                        cocona.Heal("P");
                        inventory.HealthPotion--;
                        Console.WriteLine($"ХП - {cocona.Health}");
                    }
                    else
                        Console.WriteLine("Недостаточно зелий лечения");
                    break;
                case "9":
                    break;
                default:
                    break;
            }

        }
        public void coocking(Cocona cocona, Inventory inventory)
        {
            if (inventory.RawMeat > 0)
            {
                inventory.RawMeat--;
                inventory.Steak++;
                Console.WriteLine("Вы приготовили 1 сырое мясо");
            }
            else
                Console.WriteLine("У вас нет сырого мяса");
        }

        public void BuyMeat(Cocona cocona, Inventory inventory)
        {
            if (inventory.Coins >= 5)
            {
                inventory.RawMeat++;
                inventory.Coins -= 5;
                Console.WriteLine("Вы купили 1 сырое мясо");
            }
            else
                Console.WriteLine("У вас нет нужной суммы");
        }
        public void SellMeat(Cocona cocona, Inventory inventory)
        {
            if (inventory.Steak > 0)
            {
                inventory.Steak--;
                inventory.Coins += 10;
                Console.WriteLine("Вы продали 1 приготовленное мясо");
            }
            else
                Console.WriteLine("У вас нет нужной суммы");
        }
        public void BuyPotion(Cocona cocona, Inventory inventory)
        {
            if (inventory.Coins >= 15)
            {
                inventory.Coins-=15;
                inventory.HealthPotion++;
                Console.WriteLine("Вы купили 1 зелье");
            }
            else
                Console.WriteLine("У вас нет нужной суммы");
        }
        public void Ticket(Cocona cocona, Inventory inventory, Location loco)
        {
            if (inventory.Coins >=100)
            {
                Console.WriteLine("У вас появился биллет на корабль и теперь вы сможете навсегда убраться с этого острова");
                loco.Map = 10;
            }
            else
                Console.WriteLine("У вас нет нужной суммы");
        }

    }
}
