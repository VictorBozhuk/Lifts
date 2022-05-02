using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifts
{
    class Controller
    {
        public Motor motor = new Motor();

        public Door door = new Door();

        public StateElevator stateElevator = StateElevator.wait;

        private bool FinishOnFloor = true;

        private int direction;

        public int Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public int CurrentFloor
        {
            get { return currentFloor; }
            set { currentFloor = value; }
        }

        public void Move()
        {
            if (direction == 1)
            {
                motor.Up(ref currentFloor);
                stateElevator = StateElevator.up;
            }
            else if (direction == -1)
            {
                motor.Down(ref currentFloor);
                stateElevator = StateElevator.down;
            }
            else if (direction == 2)
            {
                motor.StopOnFloor(ref FinishOnFloor);
                if (motor.StopStatus == 1) door.Open();
                else door.Close();
                if (FinishOnFloor)
                {
                    stateElevator = StateElevator.wait;
                    direction = 0;
                }
                else
                {
                    stateElevator = StateElevator.waitonfloor;
                }
            }
            else
            {
                motor.Stop();
            }
        }
    }
}