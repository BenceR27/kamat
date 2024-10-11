using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamat
{
    internal class Program
    {
        static void Kamat()
        {
            Console.WriteLine("Mennyi pénzt szeretnél befektetni? ");
            var osszeg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hány évre szeretnéd ezt az összeget befektetni? ");
            int ev = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mennyi a kamat? ");
            double kamat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mennyi a kamatozási periódusok száma évente? ");


            double vegosszeg = osszeg * Math.Pow(1 + kamat / 100, ev);

            Console.WriteLine($"{ev} év múlva: {vegosszeg:F2}Ft");
        }

        static void Main(string[] args)
        {
            Kamat();
        }
    }
}
