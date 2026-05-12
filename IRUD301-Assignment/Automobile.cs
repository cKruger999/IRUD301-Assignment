using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ProductBase
namespace IRUD301_Assignment
{
    public abstract class Automobile
    {
        public string Colour { get; set; }

        protected Chassis chassis;
        protected Shell shell;
        protected List<Wheel> wheels;
        protected Trim trim;

        public Automobile( Chassis c, Shell s, List<Wheel> w, Trim t )
        {
            this.chassis = c;
            this.shell = s;
            this.wheels = w;
            this.trim = t;
        }
    }
}
