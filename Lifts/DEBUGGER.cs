using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifts
{
    class DEBUGGER
    {
        private Scheduler _scheduler;
        public int _ticks = 0;
        int CurrentElevator = 0;
        public DEBUGGER(Scheduler scheduler)
        {
            _scheduler = scheduler;
        }

        public string print(bool CurrentElevaator, bool lifts, bool Ticks, int CurElev)
        {
            string result = "";
            if (CurrentElevaator)
            {
                result += "Відкртий ліфт:" + CurElev.ToString() + "\n";
                result += "--------------------\n";
            }
            if (lifts)
            {
                int lift = 1;
                foreach (Elevator item in _scheduler.elevators)
                {
                    string str0 = lift.ToString();
                    string str1 = item.elevatorDispatcher.controller.CurrentFloor.ToString();
                    string str2 = item.elevatorDispatcher.MainFloor.ToString();
                    string str3 = item.elevatorDispatcher.StringQueue;
                    string str4 = item.elevatorDispatcher.controller.stateElevator.ToString();

                    result += string.Format("Ліфт: {0}\nПоверх: {1}\nПотрібний поверх: {2}\nЧерга: {3}\nСтан: {4}\n", str0, str1, str2, str3, str4);
                    result += "--------------------\n";
                    lift += 1;
                }
            }
            if (Ticks)
            {
                result += "Тіки:" + _ticks.ToString() + "\n";
            }
            return result;
        }

        public string printPeopleStatus(bool CurrentElevaator, bool lifts, bool Ticks, int CurElev)
        {
            string result = "";
            if (CurrentElevaator)
            {
                result += "ліфт:" + CurElev.ToString() + "\n";
                result += "--------------------\n";
            }
            var lift = _scheduler.elevators[CurElev];
            if(lift.elevatorDispatcher.People != null)
            {
                foreach (var item in lift.elevatorDispatcher.People)
                {
                    result += $"{item.Action}\n\n";
                }
            }

            return result;
        }
    }
}
