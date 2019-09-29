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
            if (int.TryParse(inputString, out number))
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


        /// <summary>
        /// Метод подсчета геометрической прогрессии
        /// </summary>
        /// <param name="baseSeq">Основание прогрессии</param>
        /// <param name="degreeSeq">Степень</param>
        /// <returns>Сумма прогрессии</returns>
        static double CountSumSeq(double baseSeq, int degreeSeq)
        {
            double sumSeq = 0;

            // Подсчет прогрессии.
            for (int i = 0; i <= degreeSeq; i++)
            {
                sumSeq += Math.Pow(baseSeq, i);
            }

            return sumSeq;
        }




        static void Main(string[] args)
        {
            bool checkBaseSeq, checkDegreeSeq;

            // Ввод значений.
            double baseSeq = InputDoubleValue(Console.ReadLine(), out checkBaseSeq);
            int degreeSeq = InputIntValue(Console.ReadLine(), out checkDegreeSeq);


            // Проверка значений.
            if (checkBaseSeq && checkDegreeSeq && degreeSeq >= 0)
            {
                // Подсчет суммы последовательности.
                double sumSeq = CountSumSeq(baseSeq, degreeSeq);

                // Вывод суммы последовательности.
                Console.WriteLine($"{sumSeq:0.###}");
            }
            // Вывод ошибки.
            else Console.WriteLine("wrong");



            Console.ReadLine();

        }
    }
}
