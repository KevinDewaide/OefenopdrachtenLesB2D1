using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefenopdracht1Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Type een tekstline
            Console.WriteLine("Hello World");
            Console.ReadKey();

            //Maak een string variabele en voeg hier tekst aan toe
            string tekstveldje;
            tekstveldje = "duurd lang.";
            Console.WriteLine("Hello Class, " + tekstveldje);
            Console.ReadKey();

            //Maak een integer variabele en voeg hier een waarde aan toe
            int getal;
            getal = 33;
            Console.WriteLine("Hallo, " + tekstveldje + getal);
            Console.ReadKey();

            //Maak een input als string
            Console.WriteLine("Geef een input");
            string tekst2 = Console.ReadLine();
            Console.WriteLine("De ingevoerde input is: " + tekst2);
            Console.ReadKey();

            //Maak een input als getal
            Console.WriteLine("Geef een getal als input");
            string tekst3 = Console.ReadLine();
            int getal2 = Int32.Parse(tekst3);
            Console.WriteLine("De ingevoerde input is: " + getal2);
            Console.ReadKey();

            //Functie optellen
            Console.WriteLine("Optellen");
            Console.WriteLine("Voer het eerste getal in");
            string eersteInput = Console.ReadLine();
            int getal3 = Int32.Parse(eersteInput);
            Console.WriteLine("Voer het tweede geal in");
            string tweedeInput = Console.ReadLine();
            int getal4 = Int32.Parse(tweedeInput);
            int displayGetal = Optellen(getal3, getal4);
            Console.WriteLine("De totale waarde van " + getal3 + " + " + getal4 + " = " + displayGetal );
            Console.ReadKey();

            int Optellen(int a, int b)
            {
                int result = a + b;
                return result;
            }

            //Oefenopdracht stemrecht
            Console.WriteLine("Stemrecht");
            Console.WriteLine("Voer uw leeftijd in");
            string leeftijd = Console.ReadLine();
            int leeftijdInput = Int32.Parse(leeftijd);

            //leeftijd kleiner dan 18 geeft geen stemrecht
            if (leeftijdInput < 18)
            {
                Console.WriteLine("U heeft geen stemrecht");
            }

            //leeftijd groter dan 18 geeft stemrecht
            else if (leeftijdInput >= 18)
            {
                Console.WriteLine("U heeft stemrecht");
            }
            

            //Voer een getal in, dit getal zal zovaak herhaald worden als zijn eigen waarde(Voorbeeld for-loop)
            Console.WriteLine("Voer een getal in");
            string invoerGetal1 = Console.ReadLine();
            int x = Int32.Parse(invoerGetal1);
            Console.WriteLine();


            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(x);


            }

            Console.ReadKey();


            //Voorbeeld met de while-loop
            Console.WriteLine();
            int z = 2;

            do
            {
                Console.WriteLine(z);
                z++;
            }

            while (z < 10);
            Console.ReadKey();
        


            
        }
    }
}
