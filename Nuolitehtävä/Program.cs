﻿Nuoli nuoli;

Console.WriteLine("Minkä nuolen haluat");
Console.WriteLine("1. Eliitti nuoli");
Console.WriteLine("2. Aloittelijan nuoli");
Console.WriteLine("3. Perus nuoli");
Console.WriteLine("4. Luo oma nuoli");
int nuoliValikko = int.Parse(Console.ReadLine());

switch (nuoliValikko)
{
    case 1: 
        nuoli = Nuoli.LuoEliittiNuoli();
        Console.WriteLine("Nuolesi hinta on " + nuoli.PalautaHinta(nuoli) + " kultaa");
        break;
    case 2:
        nuoli = Nuoli.LuoAloittelijaNuoli();
        Console.WriteLine("Nuolesi hinta on " + nuoli.PalautaHinta(nuoli) + " kultaa");
        break;
    case 3:
        nuoli = Nuoli.LuoPerusNuoli();
        Console.WriteLine("Nuolesi hinta on " + nuoli.PalautaHinta(nuoli) + " kultaa");
        break;
    case 4:
        CustomNuoliValikko();
        break;
}

void CustomNuoliValikko()
{
    Console.WriteLine("Minkä kärjen haluat nuoleesi?");
    Console.WriteLine("Puu");
    Console.WriteLine("Teräs");
    Console.WriteLine("Timantti");
    string valittuKarki = Console.ReadLine().ToLower();

    Console.WriteLine("Minkä perän haluat nuoleesi?");
    Console.WriteLine("Lehti");
    Console.WriteLine("Kanansulka");
    Console.WriteLine("Kotkansulka");
    string valittuPera = Console.ReadLine().ToLower();

    Console.WriteLine("Minkä pituisen varren haluat? (cm)");
    int varsiPituus = int.Parse(Console.ReadLine());

    nuoli = new Nuoli(valittuKarki, valittuPera, varsiPituus);
    Console.WriteLine("Nuolesi hinta on " + nuoli.PalautaHinta(nuoli) + " kultaa");
}

class Nuoli
{
    private Nuolenkarki Karki { get;set;}

    private Nuolenpera Pera { get;set;}

    private float Varsi { get;set;}

    public Nuoli(string KARKI, string PERA, int VARSI)
    {
        switch (KARKI)
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

        switch (PERA)
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
        Varsi = VARSI;
    }

    public static Nuoli LuoEliittiNuoli()
    {
        return new Nuoli("timantti", "kotkansulka", 100);
    }

    public static Nuoli LuoAloittelijaNuoli()
    {
        return new Nuoli("puu", "kanansulka", 70);
    }

    public static Nuoli LuoPerusNuoli()
    {
        return new Nuoli("teräs", "kanansulka", 85);
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

    public float PalautaHinta(Nuoli NUOLI)
    {
        float summa = 0f;

        summa += (float)NUOLI.Karki + (float)NUOLI.Pera + (NUOLI.Varsi * 0.05f);

        return summa;
    }

}

enum Nuolenkarki {Puu = 3, Teräs = 5, Timantti = 50};
enum Nuolenpera {Lehti = 0, Kanansulka = 1, Kotkansulka = 5};