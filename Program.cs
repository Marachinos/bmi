namespace bmi
{
    internal class Program
    {
        static double CalculateBMI(double weight, double height, string unit = "metric")
        {
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
                Console.WriteLine("Okänd Enhet, retunerar 0");
                return 0;
            }
        }
            static void Main(string[] args)
        { 
                //Skapat en BMI-uträknare
            Console.WriteLine("Välkommen till BMI Kalkulatorn!");
            Console.WriteLine("===============================");
                //Ange hur lång du är (i meter)
            Console.Write("Ange hur lång du är (i meter eller inch: ");
            double height = Convert.ToDouble(Console.ReadLine());
                //Ange enhet metric (meter) eller imperial (inch)
            Console.Write("Ange enhet metric (meter) eller imperial (inch): ");
            string unit = Console.ReadLine().ToLower();
                //Ange din vikt (i kilo)
            Console.Write("Ange din vikt (i kilo): ");
            double weight = Convert.ToDouble(Console.ReadLine());
                        
            double bmi = CalculateBMI(weight, height, unit);
                //Skriv ut ditt BMI med två decimaler
            Console.WriteLine($"Ditt BMI är: {bmi:F2}");
            Console.Write("================");
        }
    }
}
