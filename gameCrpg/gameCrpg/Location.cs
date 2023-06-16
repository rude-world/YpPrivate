using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace gameCrpg
{
    public class Location
    {
        public int Map { set; get; }

        public Location(int _Map)
        {
            Map = _Map;
        }

        public void _O(Inventory inventory, Cocona cocona, Enemy Ork, bool Control2, Location loco)
        {
            Console.WriteLine("Вы спустились в самых низ канализации и замечаете большого орка в темноте");
            Console.WriteLine("Возможно к сражению с ним лучше хорошо подготовиться");
            Console.WriteLine();
            Console.WriteLine("1. В бой!");
            Console.WriteLine("2. Назад");
            Console.WriteLine("8. Статы");
            Console.WriteLine("9. Открыть инвентарь");

            string Answer = Console.ReadLine();

            switch (Answer)
            {
                case "1":
                    cocona.battle(cocona, inventory, Ork, loco);
                    if (Map != 9)
                    {
                        if (Control2 == false)
                        {
                            Console.WriteLine("Вы получили меч. Ваша атака возрасла");
                            cocona.sword();
                            Control2 = true;
                            Map = 0;
                        }
                        break;
                    }
                    else
                        break;
                case "2":
                    Map = 0;
                    break;
                case "8":
                    cocona.Stats(cocona);
                    break;
                case "9":
                    inventory.Open(cocona, inventory);
                    break;
                default:
                    Console.WriteLine("Эта команда недоступна");
                    break;
            }
        }



        public void O(Inventory inventory, Cocona cocona)
        {
            Console.WriteLine("Перед вами 2 прохода, один ведет к свету, к выходу из канализации, другой в темноту, вглубь.");
            Console.WriteLine();
            Console.WriteLine("1. К свету");
            Console.WriteLine("2. В темноту");
            Console.WriteLine("8. Статы");
            Console.WriteLine("9. Открыть инвентарь");
            string Answer = Console.ReadLine();
            switch (Answer)
            {
                case "1":
                    Map = 1;
                    break;
                case "2":
                    Map = -1;
                    break;
                case "8":
                    cocona.Stats(cocona);
                    break;
                case "9":
                    inventory.Open(cocona, inventory);
                    break;
                default:
                    Console.WriteLine("Эта команда недоступна");
                    break;
            }
        }
        public void l(Inventory inventory, Cocona cocona, Enemy rat, Location loco)
        {
            Console.WriteLine();
            Console.WriteLine("Вы продвинулись вперед, однако на пути у вас стая огромных голодных крыс ");
            Console.WriteLine("1. В бой!");
            Console.WriteLine("2. Вернутся вглубь канализации, в темноту");
            Console.WriteLine("8. Статы");
            Console.WriteLine("9. Открыть инвентарь");

            string answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    cocona.battle(cocona, inventory, rat, loco);
                    Map = 2;
                    break;      
                case "2":
                    Map = 0;
                    break;
                case "8":
                    cocona.Stats(cocona);
                    break;
                case "9":
                    inventory.Open(cocona, inventory);
                    break;
                default:
                    Console.WriteLine("Эта команда недоступна");
                    break;
            }
        }
        public void Dv(Inventory inventory, Cocona cocona, Enemy rat2,  bool Control1, Location loco)
        {
            Console.WriteLine();
            Console.WriteLine("Вы двигаетесь вперед, но пройти вам мешает крыса ");
            Console.WriteLine("1. В бой!");
            Console.WriteLine("2. Вернуться вглубь канализации");
            Console.WriteLine("8. Статы");
            Console.WriteLine("9. Открыть инвентарь");

            string answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    cocona.battle(cocona, inventory, rat2, loco);
                    if (Control1 == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine("У выхода из канализации вы находите палку и решаете, что ее можно использовать как оружие");
                        cocona.stick();
                        Console.WriteLine("Ваша атака была увеличена");
                        Control1 = true;
                        Console.WriteLine();
                    }
                        Console.WriteLine("1. Выйти из канализации ");
                        Console.WriteLine("2. Пойти вглубь канализации");
                        Console.WriteLine("8. Статы");
                        Console.WriteLine("9. Открыть инвентарь");
                        answer = Console.ReadLine();
                    switch (answer)
                    {
                        case "1":
                            Map = 3;
                            break;
                        case "2":
                            Map = 1;
                            break;
                        case "8":
                            cocona.Stats(cocona);
                            break;
                        case "9":
                            inventory.Open(cocona, inventory);
                            break;
                        default:
                            Console.WriteLine("Эта команда недоступна");
                            break;
                    }
                        break;
                    break;
                case "2":
                    Map = 1;
                    break;
                case "8":
                    cocona.Stats(cocona);
                    break;
                case "9":
                    inventory.Open(cocona, inventory);
                    break;
                default:
                    Console.WriteLine("Эта команда недоступна");
                    break;
            }
        }

        public void E(Inventory inventory, Cocona cocona)
        {
            Console.WriteLine("Вы находитесь в центре города, куда дальше?");
            Console.WriteLine();
            Console.WriteLine("1. Зайти в таверну неподалеку");
            Console.WriteLine("2. Сходить на рынок");
            Console.WriteLine("3. Пойти на пристань");
            Console.WriteLine("4. Спуститься в канализацию");
            Console.WriteLine("8. Статы");
            Console.WriteLine("9. Открыть инвентарь");

            string Answer = Console.ReadLine();

            switch (Answer)
            {
                case "1":
                    Map = 4;
                    break;
                case "2":
                    Map = 5;
                    break;
                case "3":
                    Map = 6;
                    break;
                case "4":
                    Map = 2;
                    break;
                case "8":
                    cocona.Stats(cocona);
                    break;
                case "9":
                    inventory.Open(cocona, inventory);
                    break;
                default:
                    Console.WriteLine("Эта команда недоступна");
                    break;
            }

        }
        public void Ch(Inventory inventory, Cocona cocona)
        {
            Console.WriteLine("Вы в таверне");
            Console.WriteLine();
            Console.WriteLine("1. Отдохнуть и восстановить всё ХП");
            Console.WriteLine("2. Приготовить 1 сырое мясо");
            Console.WriteLine("3. Выйти из таверны");
            Console.WriteLine("8. Статы");
            Console.WriteLine("9. Открыть инвентарь");
            Console.WriteLine();

            string Answer = Console.ReadLine();

            switch (Answer)
            {
                case "1":
                    cocona.Heal("P");
                    break;
                case "2":
                    inventory.coocking(cocona, inventory);
                    break;
                case "3":
                    Map = 3;
                    break;
                case "8":
                    cocona.Stats(cocona);
                    break;
                case "9":
                    inventory.Open(cocona, inventory);
                    break;
                default:
                    Console.WriteLine("Эта команда недоступна");
                    break;
            }

        }
        public void S(Inventory inventory, Cocona cocona, bool Control2)
        {
            Console.WriteLine();
            Console.WriteLine("Вы на рынке");
            Console.WriteLine("1. Купить меч за 50");
            Console.WriteLine("2. Купить сырое мясо за 5");
            Console.WriteLine("3. Продать приготовленное мясо за 10");
            Console.WriteLine("4. Купить зелье лечения за 15");
            Console.WriteLine("5. Покинуть рынок");
            Console.WriteLine("8. Статы");
            Console.WriteLine("9. Открыть инвентарь");
            Console.WriteLine();

            string Answer = Console.ReadLine();

            switch (Answer)
            {
                case "1":
                    if (Control2 == false)
                        if (inventory.Coins >= 50)
                        {
                            cocona.sword();
                            Control2 = true;
                        }
                        else
                            Console.WriteLine("У вас нет нужной суммы");
                    else
                        Console.WriteLine("У вас уже есть меч");
                    break;
                case "2":
                    inventory.BuyMeat(cocona, inventory);
                    break;
                case "3":
                    inventory.SellMeat(cocona, inventory);
                    break;
                case "4":
                    inventory.BuyPotion(cocona, inventory);
                    break;
                case "5":
                    Map = 3;
                    break;
                case "8":
                    cocona.Stats(cocona);
                    break;
                case "9":
                    inventory.Open(cocona, inventory);
                    break;
                default:
                    Console.WriteLine("Эта команда недоступна");
                    break;
            }
        }

        public void six(Inventory inventory, Cocona cocona, Location loco, Enemy Capitan)
        {
            Console.WriteLine();
            Console.WriteLine("Вы на пристани, здесь снабжают последний корабль, скоро уплывающий с острова");
            Console.WriteLine("1. Купить билет на корабль за 100 монет");
            Console.WriteLine("2. Напасть и захватить корабль");
            Console.WriteLine("3. Покинуть пристань");
            Console.WriteLine("8. Статы");
            Console.WriteLine("9. Открыть инвентарь");
            Console.WriteLine();

            string Answer = Console.ReadLine();

            switch (Answer)
            {
                case "1":
                    inventory.Ticket(cocona, inventory, loco);
                    break;
                case "2":
                    cocona.battle(cocona, inventory, Capitan, loco);
                    break;
                case "3":
                    Map = 3;
                    break;
                case "8":
                    cocona.Stats(cocona);
                    break;
                case "9":
                    inventory.Open(cocona, inventory);
                    break;
                default:
                    Console.WriteLine("Эта команда недоступна");
                    break;
            }
        }
        public void death()
        {
            while (true)
                Console.WriteLine("Вы погибли, начните игру заново");
        }

        public void win()
        {
            while (true)
                Console.WriteLine("Вы выжили и уплыли с острова");
        }
    }
}





