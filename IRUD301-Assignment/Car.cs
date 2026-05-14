using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Concrete Product
namespace IRUD301_Assignment
{
    public class Car : Automobile
    {
        public Car(IChassis chassis, IShell shell, List<IWheel> wheels, ITrim trim) : base(chassis, shell, wheels, trim)
        {
            
        }
        
    }
    
}
