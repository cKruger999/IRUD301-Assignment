using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Abstract Factory
namespace IRUD301_Assignment
{
    public interface IPartsFactory
    {
        IChassis CreateChassis();
        IShell CreateShell();
        IWheel CreateWheel();
        ITrim CreateTrim();
    }
}
