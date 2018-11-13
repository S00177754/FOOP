using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Game GM = new Game("Kingdom Hearts 3", 75.00m, new DateTime(2024, 12, 25));
            Game Ex1 = new Game("Monopoly", 19.99m, new DateTime(1970, 01, 31));
            Game Ex2 = new Game() { Price = 19.99m, ReleaseDate = new DateTime(2000, 6, 15) };
            Console.WriteLine(GM.ToString());
            Console.ReadKey();
        }
    }
}
