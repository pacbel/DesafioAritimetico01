using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

            double a = 0.0;
            double b = 0.0;
            double mediaP = 0.00000;

            string entradaA = Console.ReadLine().Replace(',', '.');
            string entradaB = Console.ReadLine().Replace(',', '.');

            a = Convert.ToDouble(entradaA, CultureInfo.InvariantCulture);
            b = Convert.ToDouble(entradaB, CultureInfo.InvariantCulture);

            mediaP = (( a * 3.5) + ( b * 7.5)) / (3.5 + 7.5);

            Console.WriteLine("MEDIA = {0}\n", mediaP.ToString("0.00000"));

    }

}