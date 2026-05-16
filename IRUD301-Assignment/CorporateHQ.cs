using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Invoker
namespace IRUD301_Assignment
{
    public class CorporateHQ
    {

        private ConcurrentQueue<CommandBase> _minibusOrdersQueue = new ConcurrentQueue<CommandBase>();
        private bool _isMinibusLineRunning = false;

        public void PlaceMinibusOrder(CommandBase command)
        {
            _minibusOrdersQueue.Enqueue(command);
            if (!_isMinibusLineRunning)
                ProcessMinibusOrdersInBackground();
        }

        private async void ProcessMinibusOrdersInBackground()
        {
            _isMinibusLineRunning = true;
            await Task.Run(() =>
            {
                while (_minibusOrdersQueue.TryDequeue(out CommandBase currentOrder))
                {
                    currentOrder.Execute();
                }
            });
            _isMinibusLineRunning = false;
        }

        
        private ConcurrentQueue<CommandBase> _carOrdersQueue = new ConcurrentQueue<CommandBase>();
        private bool _isCarLineRunning = false;

        public void PlaceCarOrder(CommandBase command)
        {
            _carOrdersQueue.Enqueue(command);
            if (!_isCarLineRunning)
                ProcessCarOrdersInBackground();
        }

        private async void ProcessCarOrdersInBackground()
        {
            _isCarLineRunning = true;
            await Task.Run(() =>
            {
                while (_carOrdersQueue.TryDequeue(out CommandBase currentOrder))
                {
                    currentOrder.Execute();
                }
            });
            _isCarLineRunning = false;
        }
    }
}