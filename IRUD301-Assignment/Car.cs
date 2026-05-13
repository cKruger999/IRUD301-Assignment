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
        public Car(Chassis chassis, Shell shell, List<Wheel> wheels, Trim trim) : base(chassis, shell, wheels, trim)
        {
            
        }
        
    }
    
}
