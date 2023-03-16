using System;

Ovi ovenTila = Ovi.Lukossa;

void OviLoop()
{

    Console.WriteLine("Ovi on nyt " + ovenTila);
    Console.WriteLine("Mitä haluat tehdä?: ");
    Console.WriteLine("1. Avaa ovi");
    Console.WriteLine("2. Sulje ovi");
    Console.WriteLine("3. Lukitse ovi");
    Console.WriteLine("4. Avaa lukitus");
    string vastaus = Console.ReadLine();

    if (vastaus == "1" && ovenTila == Ovi.Lukossa)
    {
        Console.WriteLine("Ovea ei voi avata koska se on lukossa");
    }
    else if (vastaus == "1" && ovenTila == Ovi.Auki)
    {
        Console.WriteLine("Ovi on jo auki");
    }
    else if (vastaus == "1" && ovenTila == Ovi.Kiinni)
    {
        Console.WriteLine("Ovi on nyt auki");
        ovenTila = Ovi.Auki;
    }

    if (vastaus == "2" && ovenTila == Ovi.Lukossa)
    {
        Console.WriteLine("Ovi on jo kiinni ja lukossa");
    }
    else if (vastaus == "2" && ovenTila == Ovi.Auki)
    {
        Console.WriteLine("Ovi on nyt suljettu");
        ovenTila = Ovi.Kiinni;
    }
    else if (vastaus == "2" && ovenTila == Ovi.Kiinni)
    {
        Console.WriteLine("Ovi on jo kiinni");
    }

    if (vastaus == "3" && ovenTila == Ovi.Lukossa)
    {
        Console.WriteLine("Ovi on lukossa");
    }
    else if (vastaus == "3" && ovenTila == Ovi.Auki)
    {
        Console.WriteLine("Ovi täytyy ensin sulkea");
    }
    else if (vastaus == "3" && ovenTila == Ovi.Kiinni)
    {
        Console.WriteLine("Ovi on nyt lukittu");
        ovenTila = Ovi.Lukossa;
    }

    if (vastaus == "4" && ovenTila == Ovi.Lukossa)
    {
        Console.WriteLine("Ovi ei ole enää lukossa");
        ovenTila = Ovi.Kiinni;
    }
    else if (vastaus == "4" && ovenTila == Ovi.Auki)
    {
        Console.WriteLine("Lukitus on jo auki");
    }
    else if (vastaus == "4" && ovenTila == Ovi.Kiinni)
    {
        Console.WriteLine("Lukitus on jo auki");
    }
    OviLoop();
}

OviLoop();

enum Ovi {Auki, Kiinni, Lukossa};
