using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifts
{
    class Elevator
    {
        public Elevator(string title) 
        {
            elevatorDispatcher = new ElevatorDispatcher(title);
        }
        public ElevatorDispatcher elevatorDispatcher;
    }
}
