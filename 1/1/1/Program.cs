string a = "hello";
string b = "world";

Console.WriteLine(a + b);


int c = 5;
int d = 6;

Console.WriteLine($"Переменные:  {c}, {d} ");
Console.WriteLine($"Сложение: {c + d}");
Console.WriteLine($"Вычитание: {c - d}");
Console.WriteLine($"Умножение: {c * d}");
Console.WriteLine($"Деление: {c / d}");


Console.WriteLine("Имя: ");
string Name = Console.ReadLine();
Console.WriteLine("Фамилия: ");
string Sername = Console.ReadLine();
Console.WriteLine("Отчество: ");
string Otchestvo = Console.ReadLine();
Console.WriteLine($"{Name}, {Sername}, {Otchestvo}");

int Php = 200;
int Patk = 60;
int Pdef = 20;
int Mhp = 400;
int Matk = 40;
int Mdef = 30;

Console.WriteLine($"Игрок - Hp осталось: {Php - Matk / Pdef}, Урона получил: {Matk / Pdef}");
Console.WriteLine($"Монстр - Hp осталось: {Mhp - Patk / Mdef}, Урона получил: {Patk / Mdef}");



