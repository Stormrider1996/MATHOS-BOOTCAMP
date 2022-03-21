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
           List<Car> Cars = new List<Car>();
           string killTheLoop = "1";
            do 
            {
                Car car = new Car();
                
                Console.WriteLine("Enter car brand");
                car.BrandName = Console.ReadLine();

                Console.WriteLine("Enter car Model");
                car.Model = Console.ReadLine();
                
                Cars.Add(car);
                
                Console.WriteLine("To finish, press 1. To continue, press any key.");
                killTheLoop = Console.ReadLine();

            } while (killTheLoop != "1");
            
            foreach (var car in Cars)
            {
                Console.WriteLine($"Car: {car.BrandName} {car.Model}\n");
            }
            Console.ReadLine();
        }
    }
}
