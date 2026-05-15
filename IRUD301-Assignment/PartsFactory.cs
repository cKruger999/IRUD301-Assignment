using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Abstract Factory
namespace IRUD301_Assignment
{
    public abstract class PartsFactory
    {
        public abstract Chassis CreateChassis();
        public abstract Shell CreateShell();
        public abstract Wheel CreateWheel();
        public abstract Trim CreateTrim();
    }
}
