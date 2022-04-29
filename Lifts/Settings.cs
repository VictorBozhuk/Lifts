using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lifts
{
    class Settings
    {
        private static Settings instance;

        private Settings()
        { }

        public static Settings getInstance()
        {
            if (instance == null)
                instance = new Settings();
            return instance;
        }

        /// <summary>
        /// Кількість поверхів
        /// </summary>
        public int FLOORCOUNT = 7;
        /// <summary>
        /// Кількість ліфтів
        /// </summary>
        public  int ELEVATORS = 7;

        /// <summary>
        /// Кількість людей в ліфті макс
        /// </summary>
        public  int ElevatorsCapacity = 5;

        /// <summary>
        /// Розмір картинки ліфта
        /// </summary>
        public  Size ELEVATORSIZE = new Size(100, 130);
        /// <summary>
        /// Розмір внутрішньої частини ліфта(мінімальний)
        /// </summary>
        public  Size ELEVATORINSIDESIZE = new Size(200, 220);

        /// <summary>
        /// Положення внутрішньої частини ліфта
        /// </summary>
        public  Point ELEVATORINSIDELOCATION = new Point(790, 0);
    }
}
