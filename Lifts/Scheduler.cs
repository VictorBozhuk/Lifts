using Lifts.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifts
{
    class Scheduler
    {
        public List<Elevator> elevators = new List<Elevator>();

        public Scheduler()
        {
            for (int i = 0; i < Settings.getInstance().ELEVATORS; i++)
            {
                elevators.Add(new Elevator((i).ToString()));
            }
            SetPeople();
        }

        void SetPeople()
        {
            elevators[0].elevatorDispatcher.People = new List<IPerson>
            {
                new User("Bob"),
                new User("Tom")
            };
            elevators[0].elevatorDispatcher.People.All(x => { x.GoIn("0"); return true; });

            elevators[1].elevatorDispatcher.People = new List<IPerson>
            {
                new Employee("Vernon"),
            };
            elevators[1].elevatorDispatcher.People.All(x => { x.GoIn("1"); return true; });


            elevators[2].elevatorDispatcher.People = new List<IPerson>
            {
                new Employee("Bas"),
                new User("Gas")

            };
            elevators[2].elevatorDispatcher.People.All(x => { x.GoIn("2"); return true; });

        }

        public void AddRequest(int direction, int floor)
        {
            //Перевірка ліфта на те, що він стоїть на даному поверсі
            if (CheckWaiting(floor)) return;
            //Перевірка ліфта на збіги напрямку
            else if (CheckByDirection(floor, direction)) return;
            //Перевірка, чи є вільні ліфти та який із них найближчий
            else if (CheckNear(floor)) return;
            //Встановити ліфт, який звільниться найближчим часом
            else if (CheckNearFree(floor)) return;
        }

        bool CheckNear(int floor)
        {
            Elevator elevmin = null;
            int min = 100;
            foreach (Elevator item in elevators)
            {
                if (item.elevatorDispatcher.controller.stateElevator == StateElevator.wait)
                {
                    if (Math.Abs(floor - item.elevatorDispatcher.controller.CurrentFloor) < min)
                    {
                        elevmin = item;
                        min = Math.Abs(floor - item.elevatorDispatcher.controller.CurrentFloor);
                    }
                }
            }
            if (elevmin == null) return false;
            elevmin.elevatorDispatcher.AddFloor(floor);
            return true; // Запит оброблений, поверх додано до черги
        }

        bool CheckWaiting(int floor)
        {
            foreach (Elevator item in elevators)
            {
                if (item.elevatorDispatcher.controller.stateElevator == StateElevator.wait && item.elevatorDispatcher.controller.CurrentFloor == floor)
                {
                    item.elevatorDispatcher.controller.Direction = 2;
                    return true; // Запит оброблений, поверх додано до черги
                }
            }
            return false; //Вільних ліфтів немає
        }
        bool CheckByDirection(int floor, int direction)
        {
            //Перевірка, чи є вільні ліфти
            foreach (Elevator item in elevators)
            {
                if (item.elevatorDispatcher.controller.Direction == direction) // Визначення напрямку
                {
                    // Якщо поточний поверх ліфта нижче поверху запиту та напрямок запиту = вгору, то додати потрібний поверх у чергу ліфта
                    if (item.elevatorDispatcher.controller.CurrentFloor < floor && direction == 1)
                    {
                        item.elevatorDispatcher.AddFloor(floor);
                        return true; // Запит оброблений, поверх додано до черги
                    }
                    // Якщо поточний поверх ліфта вище поверху запиту та напрямок запиту = вниз, то додати потрібний поверх у чергу ліфта
                    else if (item.elevatorDispatcher.controller.CurrentFloor > floor && direction == -1)
                    {
                        item.elevatorDispatcher.AddFloor(floor);
                        return true; // Запит оброблений, поверх додано до черги
                    }
                }
            }
            return false; //Вільних ліфтів немає
        }

        bool CheckNearFree(int floor)
        {
            Elevator NearElevator = elevators[0];
            foreach (Elevator item in elevators)
            {
                if (item.elevatorDispatcher.QueueCount < NearElevator.elevatorDispatcher.QueueCount)
                {
                    NearElevator = item;
                }
            }
            NearElevator.elevatorDispatcher.AddFloor(floor);
            return true; // Запит оброблений, поверх додано до черги
        }
        public void Working()
        {
            foreach (Elevator item in elevators)
            {
                item.elevatorDispatcher.DeterminingDirection();
                item.elevatorDispatcher.controller.Move();
            }
        }
    }
}