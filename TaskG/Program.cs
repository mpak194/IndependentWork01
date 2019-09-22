using System;


namespace TaskG
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
            if(int.TryParse(inputString, out number))
            {
                checkValue = true;
                return number;
            }
            checkValue = false;
            return 0;
        }



        /// <summary>
        /// Метод вычисление факториала числа
        /// </summary>
        /// <param name="number">Целочисленное число int</param>
        /// <returns>Факториал числа</returns>
        static double FindFactorial(int number)
        {
            double factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }



        static void Main(string[] args)
        {

            bool checkNumber;

            // Ввод значений.
            int number = InputIntValue(Console.ReadLine(), out checkNumber);

            // Проверка значений.
            if (checkNumber)
            {
                double sumSeq = 1;
                for (int i = 1; i <= number; i++)
                {
                    sumSeq += 1 / FindFactorial(i);
                }
                Console.WriteLine($"{sumSeq:#.#####}");
            }
            // Вывод ошибки.
            else Console.WriteLine("wrong");

            Console.ReadLine();

        }
    }
}
