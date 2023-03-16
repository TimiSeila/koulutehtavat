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

        Console.WriteLine("Minkä pituisen varren haluat? 60-100(cm)");
        varsiPituus = int.Parse(Console.ReadLine());

        Console.WriteLine("Nuolesi hinta on " + PalautaHinta(varsiPituus, valittuKarki, valittuPera) + " kultaa");

    }
    static float PalautaHinta(int pituus, string karki, string pera)
    {
        float sum = 0;
        sum += 0.5f * pituus;



        return sum;
    }

    enum NuolenKarki {Puu = 3, Teräs = 5, Timantti = 50};
    enum NuolenPera {Lehti = 0, Kanansulka = 1, Kotkansulka = 5};
}

