using System;

namespace TaskA
{
    class Program
    {
        /// <summary>
        /// Этот метод ввода целочисленного значения 
        /// </summary>
        /// <param name="inputString">Строка, которую необходимо преобразовать в int</param>
        /// <param name="checkValue">Индикатор успешности выполнения преобразования</param>
        /// <returns>Целочисленное значение</returns>
        static int InputIntValue(string inputString, out bool checkValue)
        {
            int intValue;
            checkValue = false;
            if(int.TryParse(inputString, out intValue))
            {
                checkValue = true;
                return intValue;
            }
            return 0;
        }



        /// <summary>
        /// Метод обмена значений двух переменных
        /// </summary>
        /// <param name="firstValue">Первое числовое значение</param>
        /// <param name="secondValue">Второе числовое значение</param>
        static void SwapIntValue(ref int firstValue, ref int secondValue)
        {

            //a = 3, b = 4.
            //b = b + a; a = 3, b = 7.
            //a = b - a; a = 4, b = 7.
            //b = b - a; a = 4, b = 3.

            // Алгоритм обмена значений.
            secondValue = secondValue + firstValue;
            firstValue = secondValue - firstValue;
            secondValue = secondValue - firstValue;
        }



        static void Main(string[] args)
        {
            bool checkFirstValue, checkSecondValue;

            // Ввод значений.
            int firstValue = InputIntValue(Console.ReadLine(), out checkFirstValue);
            int secondValue = InputIntValue(Console.ReadLine(), out checkSecondValue);
            

            // Проверка на успешное преобразование.
            if(checkFirstValue && checkSecondValue)
            {
                // Обмен значений.
                SwapIntValue(ref firstValue, ref secondValue);

                // Вывод результата.
                Console.WriteLine($"{firstValue} {secondValue}");

            }
            else
            {
                // Вывод ошибки.
                Console.WriteLine("wrong");
            }


            Console.ReadLine();
        }
    }
}
