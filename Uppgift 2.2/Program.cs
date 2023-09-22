using System;

namespace uppgift
{

    class Program
    {

        static void Main(string[]args)
        {
            Console.WriteLine("Hur långt hoppade Elin i meter?");
            string Elin = Console.ReadLine();
            double Elinhoppade= double.Parse(Elin);

            Console.Clear();

            Console.WriteLine("Hur långt hoppade Alma i meter?");
            string Alma =Console.ReadLine();
            double Almahoppade = double.Parse(Alma);

            double skillnad = (Elinhoppade - Almahoppade);

            Console.Clear();

            Console.WriteLine("Elin hoppade " + skillnad + " meter längre än Alma");
            Console.ReadKey();  




        }
    }
}
