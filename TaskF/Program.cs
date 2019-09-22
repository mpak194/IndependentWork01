using System;


namespace TaskF
{
    class Program
    {

        /// <summary>
        /// Метод считывания целочисленных значений
        /// </summary>
        /// <param name="inputString">Строка, которую необходимо преобразовать в int</param>
        /// <param name="checkValue">Индикатор успешного выполнения операции</param>
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
        /// Метод считывания double значений
        /// </summary>
        /// <param name="inputString">Строка, которую необходимо преобразовать в double</param>
        /// <param name="checkValue">Индикатор успешного выполнения операции</param>
        /// <returns>Значение double</returns>
        static double InputDoubleValue(string inputString, out bool checkValue)
        {
            double number;
            if (double.TryParse(inputString, out number))
            {
                checkValue = true;
                return number;
            }
            checkValue = false;
            return 0;
        }


        static void Main(string[] args)
        {
            bool checkBaseSeq, checkDegreeSeq;

            // Ввод значений.
            double baseSeq = InputDoubleValue(Console.ReadLine(), out checkBaseSeq);
            int degreeSeq = InputIntValue(Console.ReadLine(), out checkDegreeSeq);


            // Проверка значений.
            if (checkBaseSeq && checkDegreeSeq)
            {
                // Подсчет суммы последовательности.
                double sumSeq = 0;
                for (int i = 0; i <= degreeSeq; i++)
                {
                    sumSeq += Math.Pow(baseSeq, i);
                }

                // Вывод суммы последовательности.
                Console.WriteLine($"{sumSeq:#.###}");
            }
            // Вывод ошибки.
            else Console.WriteLine("wrong");


            Console.ReadLine();
   

        }
    }
}
