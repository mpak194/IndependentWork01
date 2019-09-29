using System;


namespace TaskJ
{
    class Program
    {


        /// <summary>
        /// Метод считывания целочисленных переменных
        /// </summary>
        /// <param name="inputString">Строка, которую необходимо преобразовать в int</param>
        /// <param name="checkValue">Индикатор успешного преобразования</param>
        /// <returns>Целочисленное значение int</returns>
        static int InputIntValue(string inputString, out bool checkValue)
        {
            int number;
            if (int.TryParse(inputString, out number))
            {
                checkValue = true;
                return number;
            }
            checkValue = false;
            return 0;
        }



        /// <summary>
        /// Метод определения номера числа Фибоначчи
        /// </summary>
        /// <param name="number">Проверяемое число</param>
        static void GetFibNumber(int number)
        {
            // Индикатор определения числа Фибоначчи.
            bool isFib = false;

            // Массив, содержащий ряд Фибоначчи.
            int[] FibSeq = new int[10000];
            FibSeq[0] = 0;
            FibSeq[1] = 1;

            // Порядковый номер числа Фибоначчи.
            int fibElement;

            // Проверка числа с рядом Фибоначчи.
            for (fibElement = 2; ; fibElement++)
            {
                // Формула текущего элемента.
                FibSeq[fibElement] = FibSeq[fibElement - 1] + FibSeq[fibElement - 2];


                if (number == FibSeq[fibElement])
                {
                    isFib = true;
                    break;
                }


                if (number < FibSeq[fibElement])
                {
                    isFib = false;
                    break;
                }
            }

            // Вывод результата.
            if (isFib) Console.WriteLine(fibElement);
            else Console.WriteLine("-1");
        }


        static void Main(string[] args)
        {
            bool checkNumber;


            // Ввод значений.
            int number = InputIntValue(Console.ReadLine(), out checkNumber);

            // Проверка значений.
            if (checkNumber && number > 1)
            {
                // Определение номера числа Фибоначчи.
                GetFibNumber(number);


            }
            // Вывод ошибки.
            else Console.WriteLine("wrong");


            Console.ReadLine();
        }
    }
}
