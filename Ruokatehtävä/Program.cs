using System;

(string paaRuoka, string lisuke, string kastike) annos;

Console.WriteLine("Minkä pääruoka-aineen haluat?");
Console.WriteLine("Nauta");
Console.WriteLine("Kana");
Console.WriteLine("Kasvis");
string valinta = Console.ReadLine();

annos.paaRuoka = valinta;
Console.WriteLine("Valitsit pääruoka-aineeksi: " + annos.paaRuoka);

Console.WriteLine("Minkä lisukkeen haluat?");
Console.WriteLine("Peruna");
Console.WriteLine("Riisi");
Console.WriteLine("Pasta");
valinta = Console.ReadLine();

annos.lisuke = valinta;
Console.WriteLine("Valitsit lisukkeeksi: " + annos.lisuke);

Console.WriteLine("Minkä kastikkeen haluat?");
Console.WriteLine("Pippuri");
Console.WriteLine("Chili");
Console.WriteLine("Tomaatti");
Console.WriteLine("Curry");
valinta = Console.ReadLine();

annos.kastike = valinta;
Console.WriteLine("Valitsit kastikkeeksi: " + annos.kastike);

Console.WriteLine("Ruokasi on " + annos.paaRuoka + " ja " + annos.lisuke + " " + annos.kastike + " kastikkeella");