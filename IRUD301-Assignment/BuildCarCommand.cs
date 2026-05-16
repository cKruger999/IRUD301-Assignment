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
        private Action<string> _updateUI;
        private Action<string> _updateSprayUI;
        private Action _onComplete;

        public BuildCarCommand(CarAssemblyLine assemblyLine, string colour, Action<string> updateUI, Action<string> updateSprayUI, Action onComplete)
        {
            _assemblyLine = assemblyLine;
            _colour = colour;
            _updateUI = updateUI;
            _updateSprayUI = updateSprayUI; 
            _onComplete = onComplete;

        }

        public override void Execute() 
        {
            _assemblyLine.ProcessOrder(_colour,_updateUI,_updateSprayUI);
            _onComplete?.Invoke();
        }
    }
}
