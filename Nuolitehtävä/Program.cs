using System;

class Nuoli
{
    static void Main()
    {
        string valittuKarki;
        string valittuPera;
        int varsiPituus;

        Console.WriteLine("Minkä kärjen haluat sulkaasi?");
        Console.WriteLine("Puu");
        Console.WriteLine("Teräs");
        Console.WriteLine("Timantti");
        valittuKarki = Console.ReadLine();

        Console.WriteLine("Minkä perän haluat sulkaasi?");
        Console.WriteLine("Lehti");
        Console.WriteLine("Kanansulka");
        Console.WriteLine("Kotkansulka");
        valittuPera = Console.ReadLine();

        Console.WriteLine("Minkä pituisen varren haluat? (cm)");
        varsiPituus = int.Parse(Console.ReadLine());

        Console.WriteLine("Nuolesi hinta on " + PalautaHinta(varsiPituus, valittuKarki, valittuPera) + " kultaa");

    }
    static float PalautaHinta(int pituus, string karki, string pera)
    {
        float sum = 0;

        karki.ToLower();
        pera.ToLower();

        switch (karki)
        {
            case "puu":
                sum += (float)NuolenKarki.Puu;
                break;
            case "teräs":
                sum += (float)NuolenKarki.Teräs;
                break;
            case "timantti":
                sum += (float)NuolenKarki.Timantti;
                break;
        }

        switch (pera)
        {
            case "lehti":
                sum += (float)NuolenPera.Lehti;
                break;
            case "kanansulka":
                sum += (float)NuolenPera.Kanansulka;
                break;
            case "kotkansulka":
                sum += (float)NuolenPera.Kotkansulka;
                break;
        }

        sum += 0.5f * pituus;

        return sum;
    }

    enum NuolenKarki {Puu = 3, Teräs = 5, Timantti = 50};
    enum NuolenPera {Lehti = 0, Kanansulka = 1, Kotkansulka = 5};
}

