using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifts
{
    class Motor
    {

        public int StopStatus = 0;

        public void Up(ref int floor)
        {
            if (floor != Settings.getInstance().FLOORCOUNT && StopStatus == 0) floor += 1;
        }


        public void Down(ref int floor)
        {
            if (floor - 1 != -1 && StopStatus == 0) floor -= 1;
        }

        public void Stop()
        {
        }

        public void StopOnFloor(ref bool Finished)
        {
            Finished = false;
            if (StopStatus == 0) { StopStatus = 1; Console.WriteLine("Ліфт зупинився"); } //Зупинка
            else if (StopStatus == 1) { StopStatus = 0; Console.WriteLine("Ліфт відкрив двері"); ; Finished = true; } // Відкриття дверей
            //else if (StopStatus == 2) { StopStatus = 0; Console.WriteLine("Ліфт зачинив двері"); Finished = true; } //Закриття дверей
        }
    }
}