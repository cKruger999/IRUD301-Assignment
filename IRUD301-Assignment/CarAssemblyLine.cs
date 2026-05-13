using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Receiver and Concrete Creator
namespace IRUD301_Assignment
{
    public class CarAssemblyLine : AssemblyLine
    {
        public CarAssemblyLine(PartsFactory partsFactory) : base(partsFactory)
        {

        }
        public override Automobile AssembleAutomobile()
        {
            //requests parts from abstract factory method
            Chassis myChassis = _partsFactory.CreateChassis();
            Shell myShell = _partsFactory.CreateShell();
            List<Wheel> myWheels = new List<Wheel>();
            for (int i = 0; i < 4; i++)
            {
                myWheels.Add(_partsFactory.CreateWheel());
            }
            Trim myTrim = _partsFactory.CreateTrim();
            //Adds it to a car
            Car finishedCar = new Car(myChassis, myShell, myWheels, myTrim);

            Thread.Sleep(2000);

            return finishedCar;
        }
    }
}
