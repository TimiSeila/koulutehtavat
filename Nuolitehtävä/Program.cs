Console.WriteLine("Minkä kärjen haluat sulkaasi?");
Console.WriteLine("Puu");
Console.WriteLine("Teräs");
Console.WriteLine("Timantti");
string valittuKarki = Console.ReadLine().ToLower();

Console.WriteLine("Minkä perän haluat sulkaasi?");
Console.WriteLine("Lehti");
Console.WriteLine("Kanansulka");
Console.WriteLine("Kotkansulka");
string valittuPera = Console.ReadLine().ToLower();

Console.WriteLine("Minkä pituisen varren haluat? (cm)");
int varsiPituus = int.Parse(Console.ReadLine());

Nuoli nuoli = new Nuoli(valittuKarki, valittuPera, varsiPituus);

Console.WriteLine("Nuolesi hinta on " + nuoli.PalautaHinta(nuoli) + " kultaa");

class Nuoli
{
    public Nuolenkarki Karki { get;set;}

    public Nuolenpera Pera { get;set;}

    public float Varsi { get;set;}

    public Nuoli(string karki, string pera, int varsi)
    {
        switch (karki)
        {
            case "puu":
                Karki = Nuolenkarki.Puu;
                break;
            case "teräs":
                Karki = Nuolenkarki.Teräs;
                break;
            case "timantti":
                Karki = Nuolenkarki.Timantti;
                break;
        }

        switch (pera)
        {
            case "lehti":
                Pera = Nuolenpera.Lehti;
                break;
            case "kanansulka":
                Pera = Nuolenpera.Kanansulka;
                break;
            case "kotkansulka":
                Pera = Nuolenpera.Kotkansulka;
                break;
        }
        Varsi = varsi;
    }

    public float GetKarki()
    {
        return (float)Karki;
    }

    public float GetPera()
    {
        return (float)Pera;
    }

    public float GetVarsi()
    {
        return (float)Varsi;
    }

    public float PalautaHinta(Nuoli nuoli)
    {
        float summa = 0f;

        summa += (float)nuoli.Karki + (float)nuoli.Pera + (nuoli.Varsi * 0.05f);

        return summa;
    }
}

enum Nuolenkarki {Puu = 3, Teräs = 5, Timantti = 50};
enum Nuolenpera {Lehti = 0, Kanansulka = 1, Kotkansulka = 5};