using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Components PC = new Components();
            Console.WriteLine("Welcome to PC builder!");
            Console.Write("Enter Project name: ");
            PC.ProjectName = Console.ReadLine();
            Console.Write("Enter PC Case: ");
            PC.Case = Console.ReadLine();
            Console.Write("Enter Motherboard: ");
            PC.Motherboard = Console.ReadLine();
            Console.Write("Enter Processor: ");
            PC.Processor = Console.ReadLine();
            Console.Write("Enter GPU model: ");
            PC.GPU = Console.ReadLine();
            Console.Write("Enter RAM: ");
            PC.Memory = Console.ReadLine();
            Console.Write("Enter Storage type and size: ");
            PC.Storage = Console.ReadLine();

            Console.WriteLine("Your PC specs: ");
            PC.PrintData();
        }
    }
}
