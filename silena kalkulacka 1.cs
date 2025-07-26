Console.WriteLine("--------- Kalkulačka tvoje pička ---------");
Console.Write("Zadejte číslo A: ");
string inputA = Console.ReadLine();

Console.Write("Zadejte číslo B: ");
string inputB = Console.ReadLine();

// prevod vstupu na cisla (double bo deleni s desetinnymi misty)
double a = double.Parse(inputA);
double b = double.Parse(inputB);

Console.WriteLine("\nVýpočty:");

Console.WriteLine($"{a} + {b} = {a + b}");
Console.WriteLine($"{a} - {b} = {a - b}");
Console.WriteLine($"{a} * {b} = {a * b}");
Console.WriteLine($"{a} / {b} = {a / b}");

// pro modulo musime pouzit cela cisla - prevedeme double na int
int intA = (int)a;
int intB = (int)b;
int modulo = intA % intB;
Console.WriteLine($"{intA} % {intB} = {modulo}");

Console.WriteLine("\nStisknutím klávesy ENTER ukončíte program.");
