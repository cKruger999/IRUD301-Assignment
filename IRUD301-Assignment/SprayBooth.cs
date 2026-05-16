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
            // Only take the lock if it's null
            if (_instance == null)
            {
                lock (_lockThis)
                {
                    // Check again inside the lock just in case another thread snuck in
                    if (_instance == null)
                    {
                        _instance = new SprayBooth();
                    }
                }
            }
            return _instance;
        }

        public void Paint(Automobile automobile, string colour)
        {
            Thread.Sleep(3000);
        }
    }
}
    
