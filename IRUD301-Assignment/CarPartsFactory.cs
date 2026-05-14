using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Concrete Factory
namespace IRUD301_Assignment
{
    internal class CarPartsFactory : IPartsFactory
    {
        public IChassis CreateChassis()
        {
            Console.WriteLine("Building car chassis");
            Thread.Sleep(2000);
            Console.WriteLine("Car chassis completed");
            return new CarChassis();
        }

        public IShell CreateShell()
        {
            Console.WriteLine("Building Car shell");
            Thread.Sleep(2000);
            Console.WriteLine("Car shell completed");
            return new CarShell();
        }
        public IWheel CreateWheel()
        {
            Console.WriteLine("Building Car wheel");
            Thread.Sleep(500);
            Console.WriteLine("Car wheel completed");
            return new CarWheel();
        }

        public ITrim CreateTrim()
        {
            Console.WriteLine("Building Car trim");
            Thread.Sleep(1000);
            Console.WriteLine("Car trim completed");
            return new CarTrim();
        }
    }
}
