using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Invoker
namespace IRUD301_Assignment
{
    public class CorporateHQ
    {
        private Queue<CommandBase> _minibusOrdersQueue = new Queue<CommandBase>();

        // a flag to check if the minibus assembly line is currently runnin
        private bool _isMinibusLineRunning = false;

        public void PlaceMinibusOrder(CommandBase command)
        {
            _minibusOrdersQueue.Enqueue(command);
            if (!_isMinibusLineRunning)
            {
                ProcessMinibusOrdersInBackground();
            }
        }

        //handles the threading so your GUI doesnt freeze
        private async void ProcessMinibusOrdersInBackground()
        {
            _isMinibusLineRunning = true;
            await Task.Run(() =>
            {
                while (_minibusOrdersQueue.Count > 0)
                {
                    CommandBase currentOrder = _minibusOrdersQueue.Dequeue();
                    currentOrder.Execute();
                }
            });

            _isMinibusLineRunning = false;
        }

        private Queue<CommandBase> _carOrdersQueue = new Queue<CommandBase>();
        // a flag to check if the car assembly line is currently running
        private bool _isCarLineRunning = false;

        public void PlaceCarOrder(CommandBase command)
        {
            _carOrdersQueue.Enqueue(command);
            if (!_isCarLineRunning)
            {
                ProcessCarOrdersInBackground();
            }
        }

        // handles the threading so your GUI doesnt freeze
        private async void ProcessCarOrdersInBackground()
        {
            _isCarLineRunning = true;

            await Task.Run(() =>
            {
                while (_carOrdersQueue.Count > 0)
                {
                    CommandBase currentOrder = _carOrdersQueue.Dequeue();
                    currentOrder.Execute();
                }
            });

            _isCarLineRunning = false;
        }
    }
}