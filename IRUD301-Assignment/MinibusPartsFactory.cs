using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Concrete Factory
namespace IRUD301_Assignment
{
    public class MinibusPartsFactory : PartsFactory
    {
        public override Chassis CreateChassis()
        {
            Thread.Sleep(2000); 
            return new MinibusChasis();
        }

        public override Shell CreateShell()
        {
            Thread.Sleep(3000); 
            return new MinibusShell();
        }

        public override Wheel CreateWheel()
        {
            Thread.Sleep(500); 
            return new MinibusWheel();
        }

        public override Trim CreateTrim()
        {
            Thread.Sleep(2000); 
            return new MinibusTrim();
        }
    }
}
