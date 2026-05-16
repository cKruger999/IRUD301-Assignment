using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Singleton
namespace IRUD301_Assignment
{
    public sealed class SprayBooth
    {
        private static SprayBooth _instance;
        private static object _lockThis = new object();

        public static SprayBooth GetInstance()
        {
            if (_instance == null)
            {
                lock (_lockThis)
                {
                    
                    if (_instance == null)
                    {
                        _instance = new SprayBooth();
                    }
                }
            }
            return _instance;
        }

        public void Paint(Automobile automobile, string colour, Action<string> updateUI)
        {
            if (automobile is Car)
            {
                updateUI($"Spraying {colour} LUX1000");
                Thread.Sleep(5000);
            }
            else
            {
                updateUI($"Spraying {colour} MV500");
                Thread.Sleep(7000);
            }

            automobile.Colour = colour;
            updateUI("Idle");
        }
    }
}
    
