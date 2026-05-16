using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Abstract AssemblyLine (Client for abstract factory and factory)
namespace IRUD301_Assignment
{
    public abstract class AssemblyLine
    {
        protected PartsFactory _partsFactory;
        public AssemblyLine(PartsFactory partsFactory)
        {
            _partsFactory = partsFactory;
        }
        public Automobile ProcessOrder(string colour, Action<string> updateUI, Action<string> updateSprayUI)
        {
            Automobile automobile = AssembleAutomobile(colour, updateUI);

            
            automobile.Colour = colour;
            //Singleton
            updateUI("Sent to Spraybooth");
            SprayBooth booth = SprayBooth.GetInstance();
            //Singleton method...
            booth.Paint(automobile, colour, updateSprayUI);

            updateUI("Idle");

            return automobile;
            
        }
        public abstract Automobile AssembleAutomobile(string colour, Action<string> updateUI);
        
    }
}
