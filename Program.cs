using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите свое имя: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Привет {name}. Выбери своего противника:\n1. Гоблин\n2. Рыцарь ");
        string hero1 = "Принца";
        string hero2 = "Рыцаря";
        string input = Console.ReadLine();
        if (input == "1")
        {
            Console.WriteLine($"Вы успешно выбрали {hero1}");
        }
        else
        {
            Console.WriteLine($"Вы успешно выбрали {hero2}");
        }
        Console.WriteLine("Выберите противника:\n1. Гоблин с ножиком(15 HP, 5 Урона)\n2. Гоблин-воин(25 HP, 10 Урона)\n3. Босс Гоблинов(50HP, 1 гоблин с ножиком)");
        string enemy1 = "Гоблин с ножиком";
        string enemy2 = "Гоблин-воин";
        string enemy3 = "Босс Гоблинов";
        string input2 = Console.ReadLine();
        if (input2 == "1")
        {
            Console.WriteLine($"Вы выбрали врага: {enemy1}");
        }
        if (input2 == "2")
        {
            Console.WriteLine($"Вы выбрали врага: {enemy2}");
        }
        if (input2 == "3")
        {
            Console.WriteLine($"Вы выбрали врага: {enemy3}");
        }
        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}