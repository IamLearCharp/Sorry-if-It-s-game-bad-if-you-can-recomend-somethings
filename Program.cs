using System;

class Program
{
    static void Main()
    {
        Hero prince-ru = new Hero("Рыцарь", 100, 15, 10);
        Hero archer-ru = new Hero("Лучница", 50, 20, 10);

        Enemy goblin-ru = new Enemy("Гоблин", 50, 25, 10);
        Enemy skeleton-ru = new Enemy("Скелет", 20, 35, 0);

        Hero prince-en = new Hero("Prince", 100, 15, 10);
        Hero archer-en = new Hero("Archer", 50, 20, 10);

        Enemy goblin-en = new Enemy("Goblin", 50, 25, 10);
        Enemy skeleton-en = new Enemy("Skeleton", 20, 35, 0);

        Console.WriteLine("========ДОБРО ПОЖАЛОВАТь / WELCOME========");
        Console.WriteLine("Выберите язык / Choose Language");
        string choose-lan = Console.ReadLine();

        if (choose-lan = "Русский")
        {
            Console.WriteLine("Добро пожаловать в нашу игру");
            Console.WriteLine($"Выберите героя: {prince-ru.name}, {archer-ru.name} ");
            string choose-hero = Console.ReadLine();

            if (choose-hero = "Рыцарь")
            {
                Console.WriteLine($"Вы успешно выбрали Рыцаря. Выберите противника: {goblin-ru.name}, {skeleton-ru.name}");
                string choose-enemy = Console.ReadLine();

                if (choose-enemy = "Гоблин")
                {
                    Console.WriteLine("Вы успешно выбрали гоблина противника");
                }
                if ( choose-enemy = "Скелет")
                {
                    Console.WriteLine("Вы успешно выбрали скелета противника");
                }
            }
            if (choose-hero = "Лучница")
            {
                Console.WriteLine($"Вы успешно выбрали Лучницу. Выберите противника: {goblin-ru.name}, {skeleton-ru.name}");
                string choose-enemy = Console.ReadLine();

                if (choose-enemy = "Гоблин")
                {
                    Console.WriteLine("Вы успешно выбрали гоблина противника");
                }
                if ( choose-enemy = "Скелет")
                {
                    Console.WriteLine("Вы успешно выбрали скелета противника");
                }
            }
            Console.WriteLine("Нажмите Enter что бы выйти...");
            Console.ReadLine();
        }
        if (choose-lan = "English")
        {
            Console.WriteLine("Welcome to our game");
            Console.WriteLine($"Choose a hero: {prince-en.name}, {archer-en.name} ");
            string choose-hero = Console.ReadLine();

            if (choose-hero = "Prince")
            {
                Console.WriteLine($"You choose the Prince. Choose enemy: {goblin-en.name}, {skeleton-en.name}");
                string choose-enemy = Console.ReadLine();

                if (choose-enemy = "Goblin")
                {
                    Console.WriteLine("Toy choose goblin enemy");
                }
                if ( choose-enemy = "Skeleton")
                {
                    Console.WriteLine("You choose skeleton enemy");
                }
            }
            if (choose-hero = "Archer")
            {
                Console.WriteLine($"You choose Archer. Choose enemy: {goblin.name}, {skeleton.name}");
                string choose-enemy = Console.ReadLine();

                if (choose-enemy = "Goblin")
                {
                    Console.WriteLine("You choose goblin enemy");
                }
                if ( choose-enemy = "скелет")
                {
                    Console.WriteLine("You choose skeleton enemy");
                }
            } 
            Console.WriteLine("Tap Enter to exit...");
            Console.ReadLine();  
        }
    }
}
class Hero
{
    public string Name;
    public int HP;
    public int Damage;
    public int Armor

    public Hero(string name, int hp, int damage, int armor)
    {
        Name = name;
        HP = hp;
        Damage = damage;
        Armor = armor;
    }
}
class Enemy
{
    public string Name;
    public int HP;
    public int Damage;
    public int Armor;

    public Enemy(string name, int hp, int damage, int armor)
    {
        Name = name;
        HP = hp;
        Damage = damage;
        Armor = armor;
    }   
}

