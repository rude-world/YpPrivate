using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace gameCrpg
{
    public class Cocona
    {
        public int MaxHealth { set; get; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Def { get; set; }
        public int Speed { get; set; }
        public int Level { get; set; }
        public int Kills { get; set; }


        public Cocona(int _Health, int _Attack, int _Def, int _Speed, int _Level)
        {
            Health = _Health;
            Attack = _Attack;
            Def = _Def;
            Speed = _Speed;
            Level = _Level;
            MaxHealth = _Health;
        }

        public void LevelUp(Cocona cocona)
        {
            if (cocona.Kills >= 2)
            {
                Level += 1;
                MaxHealth += 10;
                Def += 1;
                Attack += 5;
                Console.WriteLine($"Level UP! Level - {Level}, МаксХП - {MaxHealth}, Атк - {Attack}, Защита - {Def}, Шанс уворота - {Speed}");
                cocona.Kills = 0;
                if (Level > 5)
                    Speed += 1;

            }
        }

        public void stick()
        {
            Attack += 5;
        }

        public void sword()
        {
            Attack += 20;
        }

        public void Heal(string point)
        {
            if (point == "R")
                if (Health >= MaxHealth - 30)
                    Health = MaxHealth;
                else
                    Health += 30;
            if (point == "S")
                if (Health >= MaxHealth - 60)
                    Health = MaxHealth;
                else
                    Health += 60;
            if (point == "P")
                Health = MaxHealth;
        }

        public void GetDamage(int _Damage)
        {
            Random rnd = new Random();
            int chance = rnd.Next(0, Speed);
            if (chance > 0)
            {
                Console.WriteLine("Враг промазал!");
            }
            else
            {
                Health -= _Damage - Def;
            }
            Console.WriteLine($"Хп Коконы - {Health}");
        }

        public void battle(Cocona cocona, Inventory inventory, Enemy enemy, Location loco)
        {
            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Атаковать");
                Console.WriteLine("9. Открыть инвентарь");
                Console.WriteLine();
                string answe = Console.ReadLine();
                if (cocona.Health > 0)
                {
                    switch (answe)
                    {
                        case "1":
                            enemy.GetDamage(cocona.Attack);
                            break;
                        case "9":
                            inventory.Open(cocona, inventory);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Вы проиграли");
                    loco.Map = 9;
                    break;
                }
                if (enemy.RHealth > 0)
                {
                    cocona.GetDamage(enemy.RAttack);
                }
                else
                {
                    Console.WriteLine("Враг побежден");
                    if (enemy.Name == "Rat")
                    {
                        cocona.Kills++;
                        inventory.Coins += 5;
                        inventory.RawMeat++;
                    }
                    if (enemy.Name == "Ork")
                    {
                        cocona.Kills += 2;
                        inventory.Coins += 15;
                        inventory.RawMeat++;
                    }
                    if (enemy.Name == "Capitan")
                    {
                        loco.Map = 10;
                    }
                    enemy.RHealth = enemy.MaxRHealth;
                    cocona.LevelUp(cocona);
                    break;
                }
            }
        }
        public void Stats(Cocona cocona)
        {
            Console.WriteLine($"Level - {Level}, ХП - {Health}, Атк - {Attack}, Защита - {Def}, Шанс уворота - {Speed}");
        }
    }
}
