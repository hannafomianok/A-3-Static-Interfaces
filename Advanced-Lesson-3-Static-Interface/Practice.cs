using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_3_Static_Interface
{
    public partial class Practice
    {
        /// <summary>
        /// AL3-P1/3. Создать класс UniqueItem c числовым полем Id. 
        /// Каждый раз, когда создается новый экземпляр данного класса, 
        /// его идентификатор должен увеличиваться на 1 относительно последнего созданного. 
        /// Приложение должно поддерживать возможность начать идентификаторы с любого числа. 
        /// </summary>
        public static void AL3_P1_3()
        {

            for (int i = 0; i < 50; i++)
            {
                PracticeID a = new PracticeID();
            }
            Console.WriteLine(PracticeID.id);
        }

        /// <summary>
        /// AL3-P2/3. Отредактировать консольное приложение Printer. 
        /// Заменить базовый абстрактный класс на интерфейс.
        /// </summary>
        public static void AL3_P2_3()
        {

        }


        /// <summary>
        /// AL3-P3/3. Создайте обобщенный метод GuessType<T>(T item), 
        /// который будет принимать переменную обобщенного типа и выводить на консоль, 
        /// что это за тип был передан.
        /// </summary>
        public static void AL3_P3_3()
        {
            int intI = 45;
            string stringI = "Hello";
            float floatI = 4.50236F;
            DateTime dayI = DateTime.Now;

            GuessType<float>(floatI);
        }

        static void GuessType<T>(T item)
        {
            T temp = item;

            switch (temp)
            {
                case int result:
                    Console.WriteLine("Вы передали положительное целое число");
                    break;

                case string result:
                    Console.WriteLine("Вы передали строку длинной 5 символов");
                    break;

                case float result:
                    Console.WriteLine("Вы передали вещественное число с 5 значимыми цифрами");
                    break;

                case DateTime result:
                    Console.WriteLine("Вы передали время");
                    break;

                default:
                    Console.WriteLine("Понятия не имею, что вы передали");
                    break;


            }


        }









        public class PracticeID
        {
            public static int id { get; private set; }
            public string name;

            public PracticeID()
            {
                id++;
            }

            static PracticeID()
            {
                id = 1000;
            }

        }
    }
}
