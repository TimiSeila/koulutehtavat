Player player = new Player(100);

MainLoop();

void MainLoop()
{
    Console.WriteLine("You're a brave warrior protecting your home village from monters");
    Console.WriteLine($"Your health is at {player.CurrentHealth}/{player.MaxHealt} and you have {player.GoldAmount} gold");
    Console.WriteLine("Do you wish to visit the shop for new equipment or do you want to continue your journey and see what lies ahead?");
    Console.WriteLine("1. Visit the shop");
    Console.WriteLine("2. Continue journey");
    string selection = Console.ReadLine();

    switch (selection)
    {
        case "1":
            Console.WriteLine("You went to the shop");
            break;
        case "2":
            ContinueJourney();
            break;
        default:
            PrintError(selection);
            MainLoop();
            break;
    }
}

//Continue journey and randomly decide between enemy (80%) or chest (20%)
void ContinueJourney()
{
    //Generate random odds (1 in 5)
    Random rnd = new Random();
    int odds = rnd.Next(1, 6);

    //Finds chest
    if (odds == 1)
    {
        //Generate random amount of coins (10-50)
        int goldAmount = rnd.Next(1, 6);
        goldAmount *= 10;

        player.AddGold(goldAmount);
    }

    //Face an enemy
    else
    {
        //FightEnemy();
    }

    MainLoop();
}

void PrintError(string selection)
{
    Console.WriteLine($"{selection} is not an option");
}

public class Player
{
    public int MaxHealt { get; set; }
    public int CurrentHealth { get; set; }
    public int GoldAmount { get; set; }

    public Player(int MAX_HEALTH)
    {
        MaxHealt = MAX_HEALTH;
        CurrentHealth = MAX_HEALTH;
        GoldAmount = 0;
    }

    //Adds gold to player
    public void AddGold(int GOLD_AMOUNT)
    {
        GoldAmount += GOLD_AMOUNT;
    }

    //Removes gold from player
    public void RemoveGold(int GOLD_AMOUNT)
    {
        GoldAmount -= GOLD_AMOUNT;
        if (GoldAmount < 0)
        {
            GoldAmount = 0;
        }
    }

    //Handles damage made to player
    public void TakeDamage(int DAMAGE_AMOUNT)
    {
        CurrentHealth -= DAMAGE_AMOUNT;
    }
}

class Weapon
{
    public int Damage { get; set; }
    public int Cost { get; set; }
    public string Name { get; set; }

    public Weapon(int DAMAGE, int COST, string NAME)
    {
        Damage = DAMAGE;
        Cost = COST;
        Name = NAME;
    }
}

class WoodenSword : Weapon
{
    public WoodenSword() : base(6, 10, "Wooden Sword")
    {

    }
}

class SteelSword : Weapon
{
    public SteelSword() : base(18, 100, "Steel Sword")
    {

    }
}

class FireSword : Weapon
{
    public FireSword() : base(22, 250, "Fire Sword")
    {

    }
}

public abstract class Enemy
{
    public string Name { get; set; }
    public int MaxHealth { get; set; }
    public int CurrentHealth { get; set; }
    public int RewardAmount { get; set; }
    public int RegularDamage { get; set; }
    public int WeakDamage { get; set; }
    public int StrongDamage { get; set; }

    public Enemy(string NAME, int MAX_HEALTH, int REWARD_AMOUNT, int REGULAR_DAMAGE, int WEAK_DAMAGE, int STRONG_DAMAGE)
    {
        Name = NAME;
        MaxHealth = MAX_HEALTH;
        CurrentHealth = MAX_HEALTH;
        RewardAmount = REWARD_AMOUNT;
        RegularDamage = REGULAR_DAMAGE;
        WeakDamage = WEAK_DAMAGE;
        StrongDamage = STRONG_DAMAGE;
    }

    //Defines different enemy attack types
    public abstract void RegularAttack(Player player);
    public abstract void WeakAttack(Player player);
    public abstract void StrongAttack(Player player);

    public void Battle()
    {
        //Battle code
    }
}

public class Dragon : Enemy
{
    public Dragon() : base("Dragon", 100, 60, 24, 12, 36)
    {

    }

    //Performs regular attack of enemy
    public override void RegularAttack(Player player)
    {
        Console.WriteLine($"{Name} performs regular attack");
        player.TakeDamage(RegularDamage);
    }

    //Performs weak attack of enemy
    public override void WeakAttack(Player player)
    {
        Console.WriteLine($"{Name} performs weak attack");
        player.TakeDamage(WeakDamage);
    }

    //Performs strong attack of enemy
    public override void StrongAttack(Player player)
    {
        Console.WriteLine($"{Name} performs strong attack");
        player.TakeDamage(StrongDamage);
    }
}

public class Golem : Enemy
{
    public Golem() : base("Golem", 200, 90, 20, 6, 28)
    {

    }

    //Performs regular attack of enemy
    public override void RegularAttack(Player player)
    {
        Console.WriteLine($"{Name} performs regular attack");
        player.TakeDamage(RegularDamage);
    }

    //Performs weak attack of enemy
    public override void WeakAttack(Player player)
    {
        Console.WriteLine($"{Name} performs weak attack");
        player.TakeDamage(WeakDamage);
    }

    //Performs strong attack of enemy
    public override void StrongAttack(Player player)
    {
        Console.WriteLine($"{Name} performs strong attack");
        player.TakeDamage(StrongDamage);
    }
}

public class Goblin : Enemy
{
    public Goblin() : base("Goblin", 60, 30, 36, 24, 42)
    {

    }

    //Performs regular attack of enemy
    public override void RegularAttack(Player player)
    {
        Console.WriteLine($"{Name} performs regular attack");
        player.TakeDamage(RegularDamage);
    }

    //Performs weak attack of enemy
    public override void WeakAttack(Player player)
    {
        Console.WriteLine($"{Name} performs weak attack");
        player.TakeDamage(WeakDamage);
    }

    //Performs strong attack of enemy
    public override void StrongAttack(Player player)
    {
        Console.WriteLine($"{Name} performs strong attack");
        player.TakeDamage(StrongDamage);
    }
}