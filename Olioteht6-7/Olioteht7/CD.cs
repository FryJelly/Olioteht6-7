using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht7
{
    public class CD
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string Price { get; set; }

        public void PrintCdData()
        {
            Console.WriteLine("CD: ");
            Console.WriteLine("Artist: " + Artist);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("Price: " + Price);
        }
    }
}
