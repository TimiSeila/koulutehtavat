Backpack backpack = new Backpack();

void AddToBackpack()
{
    Console.WriteLine("Repussa on tällä hetkellä " + backpack.CurrentItems + "/" + backpack.MaxItems + " tavaraa, " + backpack.CurrentWeight
    + "/" + backpack.MaxWeight + " painoa, " + backpack.CurrentVolume + "/" + backpack.MaxVolume + " tilaa");
    Console.WriteLine("Minkä tavaran haluat lisätä reppuusi?");
    Console.WriteLine("1. Nuoli");
    Console.WriteLine("2. Jousi");
    Console.WriteLine("3. Köysi");
    Console.WriteLine("4. Vesi");
    Console.WriteLine("5. Ateria");
    Console.WriteLine("6. Miekka");
    int selection = int.Parse(Console.ReadLine());

    switch (selection)
    {
        case 1:
            Arrow arrow = new Arrow();
            if (backpack.CanAddToBackpack(arrow))
            {
                Console.WriteLine("Nuoli lisätty reppuun");
                AddToBackpack();
            }
            else
            {
                Console.WriteLine("Tavara ei mahdu reppuun");
                AddToBackpack();
            }
            break;
        case 2:
            Bow bow = new Bow();
            if (backpack.CanAddToBackpack(bow))
            {
                Console.WriteLine("Jousi lisätty reppuun");
                AddToBackpack();
            }
            else
            {
                Console.WriteLine("Tavara ei mahdu reppuun");
                AddToBackpack();
            }
            break;
        case 3:
            Rope rope = new Rope();
            if (backpack.CanAddToBackpack(rope))
            {
                Console.WriteLine("Köysi lisätty reppuun");
                AddToBackpack();
            }
            else
            {
                Console.WriteLine("Tavara ei mahdu reppuun");
                AddToBackpack();
            }
            break;
        case 4:
            Water water = new Water();
            if (backpack.CanAddToBackpack(water))
            {
                Console.WriteLine("Vesi lisätty reppuun");
                AddToBackpack();
            }
            else
            {
                Console.WriteLine("Tavara ei mahdu reppuun");
                AddToBackpack();
            }
            break;
        case 5:
            Meal meal = new Meal();
            if (backpack.CanAddToBackpack(meal))
            {
                Console.WriteLine("Ateria lisätty reppuun");
                AddToBackpack();
            }
            else
            {
                Console.WriteLine("Tavara ei mahdu reppuun");
                AddToBackpack();
            }
            break;
        case 6:
            Sword sword = new Sword();
            if (backpack.CanAddToBackpack(sword))
            {
                Console.WriteLine("Miekka lisätty reppuun");
                AddToBackpack();
            }
            else
            {
                Console.WriteLine("Tavara ei mahdu reppuun");
                AddToBackpack();
            }
            break;
    }
}

AddToBackpack();

class Item
{
    public float Weight { get; set; }
    public float Volume { get; set; }

    public Item(float weight, float volume)
    {
        Weight = weight;
        Volume = volume;
    }
}

class Arrow : Item
{
    public Arrow() : base(0.1f, 0.05f)
    {

    }
}

class Bow : Item
{
    public Bow() : base(1f, 4f)
    {

    }
}

class Rope : Item
{
    public Rope() : base(1f, 1.5f)
    {

    }
}

class Water : Item
{
    public Water() : base(2f, 2f)
    {

    }
}

class Meal : Item
{
    public Meal() : base(1f, 0.5f)
    {

    }
}

class Sword : Item
{
    public Sword() : base(5f, 3f)
    {

    }
}

class Backpack
{
    public int MaxItems { get; set; }
    public float MaxWeight { get; set; }
    public float MaxVolume { get; set; }

    public float CurrentItems { get; set; }
    public float CurrentWeight { get; set; }
    public float CurrentVolume { get; set; }

    Item[] itemsInBackpack = new Item[10];

    public Backpack()
    {
        MaxItems = 10;
        MaxWeight = 30f;
        MaxVolume = 20f;

        CurrentItems = 0;
        CurrentWeight = 0;
        CurrentVolume = 0;
    }

    public bool CanAddToBackpack(Item item)
    {
        if (CurrentItems < MaxItems && CurrentWeight + item.Weight <= MaxWeight && CurrentVolume + item.Volume <= MaxVolume)
        {
            for (int i = 0; i < itemsInBackpack.Length; i++)
            {
                if (itemsInBackpack[i] == null)
                {
                    itemsInBackpack[i] = item;
                    CurrentItems++;
                    CurrentWeight += item.Weight;
                    CurrentVolume += item.Volume;
                    return true;
                }
            }
        }

        return false;
    }
}