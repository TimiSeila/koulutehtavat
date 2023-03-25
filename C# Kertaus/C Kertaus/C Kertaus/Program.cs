int playerMinDamage = 1;
int playerMaxDamage = 6;
int enemyMinDamage = 1;
int enemyMaxDamage = 6;

int playerMaxHealth = 15;
int playerCurrentHealth = 15;

int enemyMaxHealth = 15;
int enemyCurrentHealth = 15;

void StartRound()
{
    int thisRoundAttackPlayer = 0;
    int thisRoundAttackEnemy = 0;

    Console.WriteLine("Olet urhea ritari ja sinut on lähetetty kukistamaan pahamaineinen örkki");
    Console.WriteLine("Löydät örkin metsästä ja tämä hyökkää sinua kohti");
    Console.WriteLine("-------------------------------------------------------------------------");
    Console.WriteLine($"Ritari(sinä): {playerCurrentHealth}/{playerMaxHealth} Örkki: {enemyCurrentHealth}/{enemyMaxHealth}");
    Console.WriteLine("1. Hyökkää miekalla");
    Console.WriteLine("2. Puolustaudu kilvellä");
    Console.WriteLine("Mitä haluat tehdä?");
    string selection = Console.ReadLine();

    switch (selection)
    {
        case "1":
            thisRoundAttackPlayer = AttackPoints(playerMinDamage, playerMaxDamage, false);
            enemyCurrentHealth -= thisRoundAttackPlayer;

            thisRoundAttackEnemy = AttackPoints(enemyMinDamage, enemyMaxDamage, false);
            playerCurrentHealth -= thisRoundAttackEnemy;
            Console.WriteLine($"Hyökkäät örkkiin ja teet {thisRoundAttackPlayer} damagea");
            Console.WriteLine($"Örkki hyökkää sinuun ja tekee {thisRoundAttackEnemy} damagea");
            break;
        case "2":
            thisRoundAttackEnemy = AttackPoints(enemyMinDamage, enemyMaxDamage, true);
            playerCurrentHealth -= thisRoundAttackEnemy;
            Console.WriteLine($"Örkki hyökkää sinuun ja tekee {thisRoundAttackEnemy} damagea");
            break;
        default:
            Console.WriteLine($"{selection} ei ole vaihtoehto");
            break;
    }

    if (playerCurrentHealth <= 0 && enemyCurrentHealth > 0)
    {
        Console.WriteLine("Hävisit");
    }
    else if (playerCurrentHealth > 0 && enemyCurrentHealth <= 0)
    {
        Console.WriteLine("Voitit");
    }
    else if(playerCurrentHealth <= 0 && enemyCurrentHealth <= 0)
    {
        Console.WriteLine("Tasapeli");
    }
    else
    {
        StartRound();
    }
}

StartRound();

int AttackPoints(int MIN, int MAX, bool HALF)
{
    Random random = new Random();

    if (HALF)
    {
        return random.Next(MIN, MAX++)/2;
    }
    else
    {
        return random.Next(MIN, MAX++);
    }
}