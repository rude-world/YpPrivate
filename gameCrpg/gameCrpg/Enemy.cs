using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameCrpg
{
    public class Enemy
    {
        public string Name { get; set; }
        public int MaxRHealth { get; set; }
        public int RHealth { get; set; }
        public int RAttack { get; set; }
        public int RDef { get; set; }
        public int RSpeed { get; set; }

        public Enemy(string _Name, int _Health, int _Attack, int _Def, int _Speed)
        {
            Name = _Name;
            RHealth = _Health;
            MaxRHealth = _Health;
            RAttack = _Attack;
            RDef = _Def;
            RSpeed = _Speed;
        }

        public void GetDamage(int _Damage)
        {
            Random rnd = new Random();
            int chance = rnd.Next(0, RSpeed);
            if (chance > 0)
            {
                Console.WriteLine("Вы промазали!");
            }
            else
                RHealth -= _Damage - RDef;
            Console.WriteLine($"Хп врага - {RHealth}");
        }
    }
}
