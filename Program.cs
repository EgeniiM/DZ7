using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7
{
    class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystals;
            int crystalPrise = 3;
            string input;

            Console.WriteLine("Здравствуйте!! Сколько у вас золота?");
            input = Console.ReadLine();
            gold = Convert.ToInt32(input);
            Console.WriteLine("Кристал стоит 3 золотых, сколько хотите купить?");
            input = Console.ReadLine();
            crystals = Convert.ToInt32(input);
            gold -= crystals * crystalPrise;
            Console.WriteLine($"У вас {gold} золота и {crystals} кристаллов");
        }
    }
}
