using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            var rand=new Random();
            Console.WriteLine("Random number {0}",rand.Next(0,100));
            Console.Read();
        }
    }
}
