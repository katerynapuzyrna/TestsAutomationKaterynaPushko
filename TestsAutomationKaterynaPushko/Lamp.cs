using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsAutomationKaterynaPushko
{
    internal class Lamp
    {
        public int id;
        public bool state;

        public Lamp(int id, bool state)
        {
            this.id = id;
            this.state = state;
        }
    }
}
