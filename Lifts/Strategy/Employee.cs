using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifts.Strategy
{
    public class Employee : IPerson
    {
        public Employee(string name) { Name = name; }
        public string Name { get; set; }
        public bool InElevator { get; set; }
        public string Elevator { get; set; }


        public string Action { get; set; }

        public void GoIn(string elevator)
        {
            InElevator = true;
            Elevator = elevator;

            Action = $"Робітник {Name} зайшов в ліфт {Elevator} і проводить ремонтні роботи";
        }

        public void GoOut()
        {
            InElevator = false;
            Elevator = string.Empty;

            Action = $"Робітник {Name} вийшов з ліфт {Elevator}";
        }

        public void NotifyStatus(LiftStatus status, string elevator)
        {
            if (status == LiftStatus.broken)
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
