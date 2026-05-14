using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
//Concrete Factory
namespace IRUD301_Assignment
{
    public class MinibusPartsFactory : IPartsFactory
    {
        public IChassis CreateChassis()
        {
            Console.WriteLine("Building minibus chassis");
            Thread.Sleep(2000);
            Console.WriteLine("Minibus chassis completed");
            return new MinibusChassis();
        }

        public IShell CreateShell()
        {
            Console.WriteLine("Building minibus shell");
            Thread.Sleep(3000);
            Console.WriteLine("Minibus shell completed");
            return new MinibusShell();
        }
        public IWheel CreateWheel()
        {
            Console.WriteLine("Building minibus wheel");
            Thread.Sleep(500);
            Console.WriteLine("Minibus wheel completed");
            return new MinibusWheel();
        }

        public ITrim CreateTrim()
        {
            Console.WriteLine("Building minibus trim");
            Thread.Sleep(2000);
            Console.WriteLine("Minibus trim completed");
            return new MinibusTrim();
        }
    }
}
