using System;
using System.Collections.Generic;
using System.Threading.Tasks;
//Invoker
namespace IRUD301_Assignment
{
    public class CorporateHQ
    {
        // --- CAR ASSEMBLY QUEUE ---

        private Queue<CommandBase> _carOrdersQueue = new Queue<CommandBase>();
        private bool _isCarLineRunning = false;

        public void PlaceCarOrder(CommandBase command)
        {
            _carOrdersQueue.Enqueue(command);

            // If the assembly line is in idle, start
            if (_isCarLineRunning == false)
            {
                _isCarLineRunning = true;

                Task.Run(() =>
                {
                    while (_carOrdersQueue.Count > 0)
                    {
                        CommandBase currentOrder = _carOrdersQueue.Dequeue();
                        currentOrder.Execute();
                    }
                    _isCarLineRunning = false;
                });
            }
        }


        // --- MINIBUS ASSEMBLY QUEUE ---

        private Queue<CommandBase> _minibusOrdersQueue = new Queue<CommandBase>();
        private bool _isMinibusLineRunning = false;

        public void PlaceMinibusOrder(CommandBase command)
        {
            _minibusOrdersQueue.Enqueue(command);

            if (_isMinibusLineRunning == false)
            {
                _isMinibusLineRunning = true;

                Task.Run(() =>
                {
                    while (_minibusOrdersQueue.Count > 0)
                    {
                        CommandBase currentOrder = _minibusOrdersQueue.Dequeue();
                        currentOrder.Execute();
                    }

                    _isMinibusLineRunning = false;
                });
            }
        }
    }
}