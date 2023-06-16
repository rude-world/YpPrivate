using gameCrpg;


Cocona cocona = new Cocona(100, 10, 3, 1, 1);
Inventory inventory = new Inventory(0, 0, 0, 0);
Enemy rat = new Enemy("Rat",20, 10, 1, 2);
Enemy rat2 = new Enemy("Rat", 20, 10, 1, 2);
Enemy Ork = new Enemy("Ork", 80, 10, 5, 1);
Enemy Capitan = new Enemy("Capitan", 200, 25, 5, 1);
Location loco = new Location(0);
bool Control1 = false;
bool Control2 = false;

Console.WriteLine("Вас зовут Кокона и вы находитесь на острове НуарАйланд. Остров уже долгое время находится в упадке. Здесь полно монстров и бандитов. Ваша цель выжить и сбежать с острова.");
Console.WriteLine("В очередной раз убегая от опасностей вы провалились в яму, в старую канализацию...");

while (true)
{
    switch (loco.Map)
    {
        case -1:
            loco._O(inventory, cocona, Ork, Control2, loco);
            break;
        case 0:
            loco.O(inventory, cocona);
            break;
        case 1:
            loco.l(inventory, cocona, rat, loco);
            break;
        case 2:
            loco.Dv(inventory, cocona, rat2, Control1, loco);
            break;
        case 3:
            loco.E(inventory, cocona);
            break;
        case 4:
            loco.Ch(inventory, cocona);
            break;
        case 5:
            loco.S(inventory, cocona, Control2);
            break;
        case 6:
            loco.six(inventory, cocona, loco, Capitan);
            break;
        case 9:
            loco.death();
            break;
        case 10:
            loco.win();
            break;
            
    }
}
    



