using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Concrete Command
namespace IRUD301_Assignment
{
    public class BuildMinibusCommand : CommandBase
    {
        private MinibusAssemblyLine _assemblyLine;

        private string _colour;
        public BuildMinibusCommand(MinibusAssemblyLine assemblyLine, string colour)
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
