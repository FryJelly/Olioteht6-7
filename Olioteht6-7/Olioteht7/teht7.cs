using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht7
{
    class Program
    {
        static void Main(string[] args)
        {
            CD nightwish = new CD();
            nightwish.Artist = "Nightwish";
            nightwish.Name = "Endless Forms Most Beautiful";
            nightwish.Genre = "Symphonic metal";
            nightwish.Price = "19.9$";

            int number;
            Console.WriteLine("Choose CD");
            Console.WriteLine("0: No CD");
            Console.WriteLine("1: Nightwish");
            int.TryParse(Console.ReadLine(),out number);
            switch (number)
            {
                case 0:
                    break;

                case 1:
                    nightwish.PrintCdData();
                    break;
               
            }
        }
    }
}
