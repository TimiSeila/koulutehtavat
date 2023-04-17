using System.Xml.Linq;

Sword sword = new Sword();
ColoredItem<Sword> coloredSword = new ColoredItem<Sword>(sword, ConsoleColor.Red);
coloredSword.ShowItem();

Arrow arrow = new Arrow();
ColoredItem<Arrow> coloredArrow = new ColoredItem<Arrow>(arrow, ConsoleColor.Green);
coloredArrow.ShowItem();

Rope rope = new Rope();
ColoredItem<Rope> coloredRope = new ColoredItem<Rope>(rope, ConsoleColor.Gray);
coloredRope.ShowItem();

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

public class ColoredItem<T> { 
    public T Item { get; set; }
    public ConsoleColor Color { get; set; }

    public ColoredItem(T item, ConsoleColor color)
    {
        Item = item;
        Color = color;
    }

    public void ShowItem()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine(Item);
    }
}