using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Concrete Command
namespace IRUD301_Assignment
{
    public class BuildCarCommand : CommandBase
    {
        private CarAssemblyLine _assemblyLine;
        private string _colour;

        public BuildCarCommand(CarAssemblyLine assemblyLine, string colour)
        {
            _assemblyLine = assemblyLine;
            _colour = colour;
        }

        public override void Execute() 
        {
            _assemblyLine.ProcessOrder(_colour);

        }
    }
}
