using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Vítejte v kalkulačce práce a mezd");

        // ziskani mzdy
        Console.Write("Zadejte hodinovou mzdu (Kč/h): ");
        double hodinovaMzda;
        while (!double.TryParse(Console.ReadLine(), out hodinovaMzda) || hodinovaMzda < 0)
        {
            Console.Write("Neplatná mzda, zadejte znovu: ");
        }

        // ziskani poctu hodin denne
        Console.Write("Zadejte počet hodin denně: ");
        int hodinDenne;
        while (!int.TryParse(Console.ReadLine(), out hodinDenne) || hodinDenne <= 0)
        {
            Console.Write("Neplatný počet hodin, zadejte znovu: ");
        }

        Console.WriteLine("1 - Spočítat potřebné hodiny pro cílovou částku");
        Console.WriteLine("2 - Spočítat výdělek z počtu hodin/dnů");
        Console.Write("Zvolte možnost (1/2): ");

        int volba;
        while (!int.TryParse(Console.ReadLine(), out volba) || (volba != 1 && volba != 2))
        {
            Console.Write("Neplatná volba, zadejte 1 nebo 2: ");
        }

        if (volba == 1)
        {
            // vypocet potrebnych hodin
            Console.Write("Zadejte cílovou částku: ");
            double cilovaCastka;
            while (!double.TryParse(Console.ReadLine(), out cilovaCastka) || cilovaCastka < 0)
            {
                Console.Write("Neplatná částka, zadejte znovu: ");
            }

            double potrebneHodiny = cilovaCastka / hodinovaMzda;
            double potrebneDny = potrebneHodiny / hodinDenne;

            Console.WriteLine($"\nPro {cilovaCastka} Kč potřebujete:");
            Console.WriteLine($"- {Math.Round(potrebneHodiny, 2)} hodin práce");
            Console.WriteLine($"- {Math.Round(potrebneDny, 2)} pracovních dnů (při {hodinDenne} hodinách denně)");
        }
        else
        {
            // vypocet vydelku z hodin nebo dnu
            Console.Write("Zadejte počet: ");
            double pocet;
            while (!double.TryParse(Console.ReadLine(), out pocet) || pocet < 0)
            {
                Console.Write("Neplatný počet, zadejte znovu: ");
            }

            Console.Write("Je to v hodinách (h) nebo dnech (d)? ");
            char jednotka;
            while (!char.TryParse(Console.ReadLine(), out jednotka) || (jednotka != 'h' && jednotka != 'd'))
            {
                Console.Write("Neplatná jednotka, zadejte 'h' nebo 'd': ");
            }

            double vydelek;
            if (jednotka == 'h')
            {
                vydelek = pocet * hodinovaMzda;
                Console.WriteLine($"\n{pocet} hodin práce vám přinese {Math.Round(vydelek, 2)} Kč");
            }
            else
            {
                vydelek = pocet * hodinDenne * hodinovaMzda;
                Console.WriteLine($"\n{pocet} pracovních dnů vám přinese {Math.Round(vydelek, 2)} Kč");
            }
        }

        Console.WriteLine("\nStiskněte jakoukoli klávesu pro ukončení...");
    }
}
