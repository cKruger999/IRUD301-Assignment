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

        protected IChassis chassis;
        protected IShell shell;
        protected List<IWheel> wheels;
        protected ITrim trim;

        public Automobile( IChassis c, IShell s, List<IWheel> w, ITrim t )
        {
            this.chassis = c;
            this.shell = s;
            this.wheels = w;
            this.trim = t;
        }
    }
}
