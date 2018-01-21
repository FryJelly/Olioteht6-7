using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht6_7
{
    class Components
    {
        public string ProjectName { get; set; }
        public string Case { get; set; }
        public string Motherboard { get; set; }
        public string Processor { get; set; }
        public string GPU { get; set; }
        public string Memory { get; set; }
        public string Storage { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Project Name: ");
            Console.WriteLine("Case: " + Case);
            Console.WriteLine("Motherboard: " + Motherboard);
            Console.WriteLine("Processor: " + Processor);
            Console.WriteLine("GPU: " + GPU);
            Console.WriteLine("Memory: " + Memory);
            Console.WriteLine("Storage: " + Storage);

        }
    }
}
