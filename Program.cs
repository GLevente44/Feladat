using System;
using System.Collections.Generic;
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

        public static void Bank()
        {
            

        }

        static void Main(string[] args)
        {
            Udvozles();
            Console.WriteLine("");
            Bank();
        }
    }
}
