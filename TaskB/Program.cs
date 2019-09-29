using System;

namespace TaskB
{
    class Program
    {


        /// <summary>
        /// Метод для ввода целочисленных значений
        /// </summary>
        /// <param name="inputString">Строка, которую необходимо преобразовать в int</param>
        /// <param name="checkValue">Индикатор успешности выполнения преобразования</param>
        /// <returns>int значение строки</returns>
        static int InputIntValue(string inputString, out bool checkValue)
        {
            int intNumber;
            checkValue = false;
            if (int.TryParse(inputString, out intNumber))
            {
                checkValue = true;
                return intNumber;
            }
            return 0;
        }

        /// <summary>
        /// Метод проверки числа на симметричность
        /// </summary>
        /// <param name="number">Проверяемое число</param>
        /// <returns>Булевое значение, является ли число симметричным или нет</returns>
        static bool IsSymmetryNumber(int number)
        {

            string stringNumber = number.ToString();


            return stringNumber[0] - stringNumber[3] == 0 && stringNumber[1] - stringNumber[2] == 0;

        }


        /// <summary>
        /// Метод, проверяющий число на четырехзначность
        /// </summary>
        /// <param name="number">Проверяемое число</param>
        /// <returns>Значение типа bool</returns>
        static bool IsFourDigit(int number)
        {
            number /= 1000;
            return number <= 9 && number >= 1;
        }


        static void Main(string[] args)
        {
            bool checkValue;

            // Ввод значений.
            int number = InputIntValue(Console.ReadLine(), out checkValue);

            // Проверка введенных значений.
            if (checkValue && IsFourDigit(number))
            {
                // Проверка на симметричность.
                if (IsSymmetryNumber(number)) Console.WriteLine("1");
                else Console.WriteLine("6");
            }
            // Вывод ошибки.
            else Console.WriteLine("wrong");

            Console.ReadKey();
        }
    }
}
