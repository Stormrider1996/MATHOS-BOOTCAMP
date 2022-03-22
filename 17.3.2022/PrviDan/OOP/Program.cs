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
                Car NewCar = new Car();
                
                Console.WriteLine("Enter car brand");
                NewCar.BrandName = Console.ReadLine();

                Console.WriteLine("Enter car Model");
                NewCar.Model = Console.ReadLine();
                
                Cars.Add(NewCar);
                
                Console.WriteLine("To finish, press 1. To continue, press any key.");
                killTheLoop = Console.ReadLine();

            } while (killTheLoop != "1");
            
            foreach (Car NewCar in Cars)
            {
                Console.WriteLine($"Car: {NewCar.BrandName} {NewCar.Model}\n");
            }
            Console.ReadLine();
        }
    }
}
