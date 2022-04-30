using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifts.Strategy
{
    public interface IPerson
    {
        string Elevator { get; set; }
        bool InElevator { get; set; }
        string Name { get; set; }

        string Action { get; set; }

        void GoIn(string elevator);

        void GoOut();

        void NotifyStatus(LiftStatus status, string elevator);
    }
}
