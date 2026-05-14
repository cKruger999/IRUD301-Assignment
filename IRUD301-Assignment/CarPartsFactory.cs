using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Concrete Factory
namespace IRUD301_Assignment
{
    internal class CarPartsFactory : IPartsFactory
    {
        public event Action<string> OnStatusUpdate;

        public IChassis CreateChassis()
        {
            OnStatusUpdate?.Invoke("Building car chassis");
            Thread.Sleep(2000);
            OnStatusUpdate?.Invoke("Car chassis completed");
            return new CarChassis();
        }

        public IShell CreateShell()
        {
            OnStatusUpdate?.Invoke("Building Car shell");
            Thread.Sleep(2000);
            OnStatusUpdate?.Invoke("Car shell completed");
            return new CarShell();
        }
        public IWheel CreateWheel()
        {
            OnStatusUpdate?.Invoke("Building Car wheel");
            Thread.Sleep(500);
            OnStatusUpdate?.Invoke("Car wheel completed");
            return new CarWheel();
        }

        public ITrim CreateTrim()
        {
            OnStatusUpdate?.Invoke("Building Car trim");
            Thread.Sleep(1000);
            OnStatusUpdate?.Invoke("Car trim completed");
            return new CarTrim();
        }
    }
}
