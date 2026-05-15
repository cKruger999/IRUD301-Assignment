using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Concrete Factory
namespace IRUD301_Assignment
{
    internal class CarPartsFactory : PartsFactory
    {
        public override Chassis CreateChassis()
        {
            Thread.Sleep(2000); 
            return new CarChasis();
        }

        public override Shell CreateShell()
        {
            Thread.Sleep(2000); 
            return new CarShell();
        }

        public override Wheel CreateWheel()
        {
            Thread.Sleep(500); 
            return new CarWheel();
        }

        public override Trim CreateTrim()
        {
            Thread.Sleep(1000); 
            return new CarTrim();
        }
    }
}
