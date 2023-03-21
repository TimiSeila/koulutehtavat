using System.Xml.Linq;

Backpack backpack = new Backpack(10, 30f, 20f);

void AddToBackpack()
{
    Console.WriteLine($"Repussa on tällä hetkellä {backpack.CurrentItems}/{backpack.MaxItems} tavaraa, {backpack.CurrentWeight: #0.00}/{backpack.MaxWeight} painoa, {backpack.CurrentVolume: #0.00}/{backpack.MaxVolume} tilaa");
    Console.WriteLine(backpack.ToString());
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
        default:
            Console.WriteLine($"{selection} ei ole vaihtoehto");
            break;
    }
}

AddToBackpack();

class Item
{
    public float Weight { get; set; }
    public float Volume { get; set; }
    public string Name { get; set; }
    
    public Item(float WEIGHT, float VOLUME, string NAME)
    {
        Weight = WEIGHT;
        Volume = VOLUME;
        Name = NAME;
    }
}

class Arrow : Item
{
    public Arrow() : base(0.1f, 0.05f, "Nuoli")
    {

    }
    public override string ToString()
    {
        return Name;
    }
}

class Bow : Item
{
    public Bow() : base(1f, 4f, "Jousi")
    {

    }

    public override string ToString()
    {
        return Name; 
    }
}

class Rope : Item
{
    public Rope() : base(1f, 1.5f, "Köysi")
    {

    }
    public override string ToString()
    {
        return Name;
    }
}

class Water : Item
{
    public Water() : base(2f, 2f, "Vesi")
    {

    }
    public override string ToString()
    {
        return Name;
    }
}

class Meal : Item
{
    public Meal() : base(1f, 0.5f, "Ateria")
    {

    }
    public override string ToString()
    {
        return Name;
    }
}

class Sword : Item
{
    public Sword() : base(5f, 3f, "Miekka")
    {

    }
    public override string ToString()
    {
        return Name;
    }
}

class Backpack
{
    public int MaxItems { get; set; }
    public float MaxWeight { get; set; }
    public float MaxVolume { get; set; }

    public int CurrentItems { get; set; }
    public float CurrentWeight { get; set; }
    public float CurrentVolume { get; set; }

    Item[] itemsInBackpack = new Item[10];

    public Backpack(int MAXITEMS, float MAXWEIGHT, float MAXVOLUME)
    {
        MaxItems = MAXITEMS;
        MaxWeight = MAXWEIGHT;
        MaxVolume = MAXVOLUME;

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

    public override string ToString()
    {
        string insideBackpack = "";
        foreach(Item item in itemsInBackpack)
        {
            if(item != null)
            {
                insideBackpack = insideBackpack + item.ToString() + ", ";
            }
        }

        return $"Repussasi on nyt: {insideBackpack}";
    }
}