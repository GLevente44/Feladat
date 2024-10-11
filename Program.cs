using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraimunka
{
    internal class Program
    {

        public static void Udvozles()
        {

            int ora = DateTime.Now.Hour;
            if (ora >= 5 && ora < 12)
            {
                Console.WriteLine("Jó reggelt!");
            }
            else if (ora >= 12 && ora < 18)
            {
                Console.WriteLine("Jó napot!");
            }

            else if (ora >= 18 && ora < 22)
            {
                Console.WriteLine("Jó estét!");
            }
           
        }

        public static void Kamat()
        {
            Console.Write("Adja meg, hogy mennyi összeget szeretne berakni a bankba: ");
            int osszeg = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg mennyi évre szeretné berakni? ");
            int ev = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a kamatot százalékban: ");
            double kamat = Convert.ToDouble(Console.ReadLine());


            double vegso_osszeg = osszeg * Math.Pow(1 + kamat / 100, ev);

            Console.WriteLine($"A berakott összeg {ev} év múlva: {vegso_osszeg} forint.");
        }

        public static void Futas()
        {
            Console.Write("Adja meg a futó kezdő sebességét m/s-ban (3.00-5.00 intervallumon belül): ");
            string futo = Console.ReadLine();

            

        }

        static void Main(string[] args)
        {
             //Udvozles();
            Console.WriteLine("");
            Kamat();
            // Console.WriteLine("");
            Futas();
        }
    }
}
