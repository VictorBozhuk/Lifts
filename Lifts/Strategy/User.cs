using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifts.Strategy
{
    public class User : IPerson
    {
        public User(string name) { Name = name; }

        public string Name { get; set; }
        public bool InElevator { get; set; }
        public string Elevator { get; set; }

        public string Action { get; set; }

        public void GoIn(string elevator)
        {
            InElevator = true;
            Elevator = elevator;

            Action = $"Користувач {Name} зайшов в ліфт {Elevator} і чекає";
        }

        public void GoOut()
        {
            InElevator = false;
            Elevator = string.Empty;

            Action = $"Користувач {Name} вийшов з ліфт {Elevator}";
        }

        public void NotifyStatus(LiftStatus status, string elevator)
        {
            if (status == LiftStatus.worker)
            {
                GoIn(elevator);
            }
            else
            {
                GoOut();
            }
        }
    }
}
