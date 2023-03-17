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
    private Nuolenkarki _karki;
    Nuolenpera _pera;
    int _varsi;
    public Nuoli(string karki, string pera, int varsi)
    {
        switch (karki)
        {
            case "puu":
                _karki = Nuolenkarki.Puu;
                break;
            case "teräs":
                _karki = Nuolenkarki.Teräs;
                break;
            case "timantti":
                _karki = Nuolenkarki.Timantti;
                break;
        }

        switch (pera)
        {
            case "lehti":
                _pera = Nuolenpera.Lehti;
                break;
            case "kanansulka":
                _pera = Nuolenpera.Kanansulka;
                break;
            case "kotkansulka":
                _pera = Nuolenpera.Kotkansulka;
                break;
        }
        _varsi = varsi;
    }

    public float GetKarki()
    {
        return (float)_karki;
    }

    public float GetPera()
    {
        return (float)_pera;
    }

    public float GetVarsi()
    {
        return (float)_varsi;
    }

    public float PalautaHinta(Nuoli nuoli)
    {
        float summa = 0f;

        summa += (float)nuoli._karki + (float)nuoli._pera + (nuoli._varsi * 0.05f);

        return summa;
    }
}

enum Nuolenkarki {Puu = 3, Teräs = 5, Timantti = 50};
enum Nuolenpera {Lehti = 0, Kanansulka = 1, Kotkansulka = 5};