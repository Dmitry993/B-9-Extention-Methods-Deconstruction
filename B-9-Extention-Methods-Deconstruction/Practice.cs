using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Lesson_9.Practice
{
    public static class Practice
    {
        public struct Coordinates
        {
            public int x, y, z;

            public void Deconstruct(out int x, out int y, out int z, out double vector)
            {
                x = this.x;
                y = this.y;
                z = this.z;
                vector = Math.Sqrt(x * x + y * y + z * z);

            }
        }
        /// <summary>
        /// L9-P-EX-1/2
        /// Создать структуру Coordinates (трехмерных). 
        /// Добавить экземплярный метод деконструкции значений координат.
        /// Вывести на консоль длину вектора по координатам.
        /// </summary>
        public static void L9_P_EX_1_from_2()
        {
            var coordinate1 = new Coordinates { x = 3, y = 4, z = 2 };
            var (_, _, _, result) = coordinate1;
            Console.WriteLine(result);
        }

        /// <summary>
        /// L9-P-EX-2/2. 
        /// Создать деконструктор для обьекта DateTime 
        /// (год, месяц, день, час, минуты, секунды). 
        /// Получить и вывести на консоль текущее время.
        /// Использовать пустые параметры.
        /// </summary>
        public static void L9_P_EX_2_from_2()
        {
            DateTime time = DateTime.Now;
            var (_, _, _, hour, minute, second) = time;
            Console.WriteLine($"{hour:00}:{minute:00}:{second:00}");
        }

        public static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day, out int hour, out int minute, out int second)
        {
            year = dateTime.Year;
            month = dateTime.Month;
            day = dateTime.Day;
            hour = dateTime.Hour;
            minute = dateTime.Minute;
            second = dateTime.Second;
        }
    }
}
