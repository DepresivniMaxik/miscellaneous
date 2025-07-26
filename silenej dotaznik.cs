Console.WriteLine("--------- Osobní dotazník ---------");

Console.WriteLine("Ahoj, jak se jmenujete?");
string jmeno = Console.ReadLine();

Console.WriteLine("\nKolik je Vám let?");
int vek = int.Parse(Console.ReadLine());

Console.WriteLine("\nKam chodíte do školy?");
string skola = Console.ReadLine();

Console.WriteLine("\nJaké máte záliby?");
string zaliby = Console.ReadLine();

Console.WriteLine("\nProgram nyní čeká na stisknutí klávesy ENTER a následně bude pokračovat. (program čeká)");
Console.ReadLine();

Console.WriteLine("\nVýpis ze zadaných informací:");
Console.WriteLine($"Vaše jméno: {jmeno}");
Console.WriteLine($"Váš věk je: {vek}");
Console.WriteLine($"Chodíte do školy: {skola}");
Console.WriteLine($"Vaše záliby jsou: {zaliby}");

Console.WriteLine("\nDěkujeme za vyplnění dotazníku!");
