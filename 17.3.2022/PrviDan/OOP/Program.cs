using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a car dealer");
            CarDealer newDealer = new CarDealer();
            newDealer.nameOfDealer = Console.ReadLine();
            Console.WriteLine(newDealer.nameOfDealer);
            Console.ReadLine();
        }
    }
}
