using System;

class Program
{
    static void Main()
    {
        Hero princeRu = new Hero("Рыцарь", 100, 15, 10);
        Hero archerRu = new Hero("Лучница", 50, 20, 10);
        Enemy goblinRu = new Enemy("Гоблин", 50, 25, 10);
        Enemy skeletonRu = new Enemy("Скелет", 20, 35, 0);

        Hero princeEn = new Hero("Prince", 100, 15, 10);
        Hero archerEn = new Hero("Archer", 50, 20, 10);
        Enemy goblinEn = new Enemy("Goblin", 50, 25, 10);
        Enemy skeletonEn = new Enemy("Skeleton", 20, 35, 0);

        Console.WriteLine("========ДОБРО ПОЖАЛОВАТЬ / WELCOME========");
        string chooseLan = "";
        while (chooseLan != "1" && chooseLan != "2")
        {
            Console.WriteLine("1. Русский");
            Console.WriteLine("2. English");
            chooseLan = Console.ReadLine().Trim();
        }

        if (chooseLan == "1")
        {
            Console.WriteLine("Добро пожаловать в нашу игру!");

            string chooseHero = "";
            while (chooseHero != "1" && chooseHero != "2")
            {
                Console.WriteLine($"Выберите героя:\n1. {princeRu.Name}\n2. {archerRu.Name}");
                chooseHero = Console.ReadLine().Trim();
            }

            Hero selectedHero = chooseHero == "1" ? princeRu : archerRu;
            Console.WriteLine($"Вы выбрали: {selectedHero.Name}!");

            string chooseEnemy = "";
            while (chooseEnemy != "1" && chooseEnemy != "2")
            {
                Console.WriteLine($"Выберите противника:\n1. {goblinRu.Name}\n2. {skeletonRu.Name}");
                chooseEnemy = Console.ReadLine().Trim();
            }

            Enemy selectedEnemy = chooseEnemy == "1" ? goblinRu : skeletonRu;
            Console.WriteLine($"Вы выбрали противника: {selectedEnemy.Name}!");

            Console.WriteLine("Нажмите Enter чтобы выйти...");
            Console.ReadLine();
        }
        else if (chooseLan == "2")
        {
            Console.WriteLine("Welcome to our game!");

            string chooseHero = "";
            while (chooseHero != "1" && chooseHero != "2")
            {
                Console.WriteLine($"Choose a hero:\n1. {princeEn.Name}\n2. {archerEn.Name}");
                chooseHero = Console.ReadLine().Trim();
            }

            Hero selectedHero = chooseHero == "1" ? princeEn : archerEn;
            Console.WriteLine($"You chose: {selectedHero.Name}!");

            string chooseEnemy = "";
            while (chooseEnemy != "1" && chooseEnemy != "2")
            {
                Console.WriteLine($"Choose enemy:\n1. {goblinEn.Name}\n2. {skeletonEn.Name}");
                chooseEnemy = Console.ReadLine().Trim();
            }

            Enemy selectedEnemy = chooseEnemy == "1" ? goblinEn : skeletonEn;
            Console.WriteLine($"You chose enemy: {selectedEnemy.Name}!");

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
    public int Armor;

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