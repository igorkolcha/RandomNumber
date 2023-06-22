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
            Console.WriteLine("Random number {0}",rand.Next(5));

            Console.WriteLine("Five random numbers");
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                int number = random.Next(101);
                Console.Write(number + " | ");
            }
            Console.Read();
        }
    }
}
