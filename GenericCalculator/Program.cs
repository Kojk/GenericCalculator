using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int a = Convert.ToInt32(line);
            line = Console.ReadLine();
            int b = Convert.ToInt32(line);

            IntCalculator intCalculator = new IntCalculator();

            int sucet =  intCalculator.Add(a, b);
            Console.WriteLine("vysledok je {0} ", sucet);


            Console.WriteLine("sucin");

            line = Console.ReadLine();
            float c = (float)Convert.ToDouble(line);
            line = Console.ReadLine();
            float d = (float)Convert.ToDouble(line);

            FloatCalculator floatCalculator = new FloatCalculator();

            float sucin = floatCalculator.Multiply(c, d);
            Console.WriteLine("vysledok je {0:0.00} ", sucin);   // formatovanie na dve desatine cisla

            //novy cshar postup na formatovanie stringu
            string novyFormat = $"vysledok je {sucet} a dalsi vysledok je{sucin}";
            //pred riadiace znaky davam lomitko, aby som to zadal ako obyč text
            string cestaKSouboru = "c\\temp\\log.txt";
            // nebo pred cely retazec uvedu zavinac (@) aby ignoroval ridici znaky
            string cestaKSouboru1 = @"c\temp\log.txt";

            Console.WriteLine("konec \"programu\"  \a ");      // backslash 



            Console.ReadKey();
        }
    }
}
