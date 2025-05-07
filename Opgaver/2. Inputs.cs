using System;
using System.ComponentModel.Design;

namespace Opgaver
{
    public class Inputs
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Expressions, Operators og Inputs!");
            String1();
            Int1();
            Double1();
            Bool1();

            // Mini-projekter til inspiration:
            MiniProjekt1();
            MiniProjekt2();
        }

        public static void String1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som en string og skriver strengen ud i konsollen"
            );

            Console.WriteLine("Indtast en streng: ");
            // Lav opgaven herunder!
            string message = Console.ReadLine();
            Console.WriteLine(message);



        }

        public static void Int1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som et tal og skriver tallet ud i konsollen"
            );

            Console.WriteLine("Indtast et tal: ");
            // Lav opgaven herunder!
            int tal = int.Parse(Console.ReadLine());
            Console.WriteLine(tal);
        }

        public static void Double1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som et decimaltal og skriver tallet ud i konsollen"
            );

            Console.WriteLine("Indtast et decimaltal: ");
            // Lav opgaven herunder!
            decimal tal = decimal.Parse( Console.ReadLine() );
            Console.WriteLine(tal);
        }

        public static void Bool1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som en sandhedsværdi og skriver værdien ud i konsollen"
            );

            Console.WriteLine("Indtast en sandhedsværdi (sandt/falsk): ");
            // Lav opgaven herunder!
            string input = Console.ReadLine();
            bool sandhedsværdi;
            if (bool.TryParse(input,out sandhedsværdi))
            Console.WriteLine("Du indtastede: " + sandhedsværdi);
            else
                Console.WriteLine("Det var ikke en gyldig sandhedsværdi (skriv 'sandt' eller 'falsk'");
        }

        // Mini-projekt: Personlig profil (skabelon)
        public static void MiniProjekt1()
        {
            Console.WriteLine("\nMini-projekt: Personlig profil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster sit navn, alder og hjemby.");
            Console.WriteLine(
                "Gem oplysningerne i variabler og udskriv en præsentationstekst, der bruger alle oplysningerne."
            );
            Console.WriteLine("Eksempel: Hej, jeg hedder X, er X år gammel og kommer fra X!");
            // Lav opgaven herunder!
            Console.WriteLine("Indtast dit navn: ");
            string navn = Console.ReadLine();
            int alder = int.Parse(Console.ReadLine());
            string hjemby = Console.ReadLine();
            Console.WriteLine($"Hej,jeg hedder {navn}, er {alder} år gammel og kommer fra {hjemby} !\");");


        }

        // Mini-projekt 2: BMI-beregner (skabelon)
        public static void MiniProjekt2()
        {
            Console.WriteLine("\nMini-projekt 2: BMI-beregner (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster sin vægt (i kg) og højde (i meter)."
            );
            Console.WriteLine("Programmet skal beregne brugerens BMI og udskrive resultatet.");
            Console.WriteLine(
                "Tip: BMI beregnes som vægt divideret med højde i anden (BMI = vægt / (højde * højde))."
            );
            Console.WriteLine("Indtast din vægt i kg: ");
            double vægt = double.Parse(Console.ReadLine());
            Console.WriteLine("Indtast din højde i meter: ");
            double højde = double.Parse(Console.ReadLine());
            double bmi = vægt / (højde * højde);
            Console.WriteLine($"Din BMI er:{bmi:F2}");

        }
    }
}
