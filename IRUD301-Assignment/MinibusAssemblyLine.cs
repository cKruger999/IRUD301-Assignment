using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Receiver and Concrete Creator
namespace IRUD301_Assignment
{
    public class MinibusAssemblyLine : AssemblyLine
    {
        public MinibusAssemblyLine(PartsFactory partsFactory) : base(partsFactory)
        {
           
        }
        public override Automobile AssembleAutomobile(string colour, Action<string> updateUI)
        {
            string modelName = "LUX1000";
            //requests parts from abstract factory method
            updateUI($"Creating {colour} {modelName} Chassis");
            Chassis myChassis = _partsFactory.CreateChassis();
            updateUI($"Creating {colour} {modelName} Shell");
            Shell myShell = _partsFactory.CreateShell();
            List<Wheel> myWheels = new List<Wheel>();
            for (int i = 0; i < 4; i++)
            {
                string wheelPosition = "";
                if (i == 0) wheelPosition = "Front Left";
                if (i == 1) wheelPosition = "Front Right";
                if (i == 2) wheelPosition = "Back Left";
                if (i == 3) wheelPosition = "Back Right";

                updateUI($"Creating {colour} {modelName} {wheelPosition} Wheel");
                myWheels.Add(_partsFactory.CreateWheel());
            }
            updateUI($"Creating {colour} {modelName} Trim");
            Trim myTrim = _partsFactory.CreateTrim();
            //Adds it to a car
            Minibus finishedMinibus = new Minibus(myChassis, myShell, myWheels, myTrim);
            updateUI($"{modelName} Assembly");
            Thread.Sleep(2000);

            return finishedMinibus;
        }
    }
}
