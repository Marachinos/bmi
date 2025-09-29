using System;

namespace bmi
{
    internal class Program
    {
        static double CalculateBMI(double weight, double height, string unit = "metric")
        {
            if (height <= 0)
            {
                Console.WriteLine("Fel: Längden måste vara större än 0.");
                return 0;
            }

            if (weight <= 0)
            {
                Console.WriteLine("Fel: Vikten måste vara större än 0.");
                return 0;
            }

            if (unit == "metric")
            {
                return weight / (height * height);
            }
            else if (unit == "imperial")
            {
                return 703 * (weight / (height * height));
            }
            else
            {
                Console.WriteLine("Fel: Okänd enhet, returnerar 0.");
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till BMI Kalkulatorn!");
            Console.WriteLine("===============================");

            double height;
            while (true)
            {
                Console.Write("Ange hur lång du är (i meter eller inch): ");
                if (double.TryParse(Console.ReadLine(), out height) && height > 0)
                    break;
                Console.WriteLine("Ogiltig inmatning! Ange ett positivt tal för längden.");
            }

            string unit;
            while (true)
            {
                Console.Write("Ange enhet (metric för meter eller imperial för inch): ");
                unit = Console.ReadLine().ToLower();
                if (unit == "metric" || unit == "imperial")
                    break;
                Console.WriteLine("Ogiltig enhet! Ange 'metric' eller 'imperial'.");
            }

            double weight;
            while (true)
            {
                Console.Write("Ange din vikt (i kilo): ");
                if (double.TryParse(Console.ReadLine(), out weight) && weight > 0)
                    break;
                Console.WriteLine("Ogiltig inmatning! Ange ett positivt tal för vikten.");
            }

            double bmi = CalculateBMI(weight, height, unit);

            if (bmi > 0)
            {
                Console.WriteLine("===============================");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Ditt BMI är: {bmi:F2}");
                Console.ResetColor();   
            }

            Console.WriteLine("===============================");
        }
    }
}
