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
        private Action<string> _updateUI;
        private Action _onComplete;
        public BuildMinibusCommand(MinibusAssemblyLine assemblyLine, string colour, Action<string> updateUI, Action onComplete)
        {
            _assemblyLine = assemblyLine;
            _colour = colour;
            _updateUI = updateUI;
            _onComplete = onComplete;

        }

        public override void Execute()
        {
            _assemblyLine.ProcessOrder(_colour, _updateUI);
            _onComplete?.Invoke();

        }

    }
}
