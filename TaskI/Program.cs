using System;


namespace TaskI
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
        /// Метод определения точной степени двойки
        /// </summary>
        /// <param name="number"></param>
        static void IsDegreeTwo(int number)
        {
            // Индикатор поиска степени двойки.
            bool isDegree = false;

            for (long i = 1; i <= number; i *= 2)
            {
                if (i == number)
                {
                    isDegree = true;
                    break;
                }
                
            }

            // Вывод результата.
            if (isDegree) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }



        static void Main(string[] args)
        {
            bool checkNumber;


            // Ввод значений.
            int number = InputIntValue(Console.ReadLine(), out checkNumber);

            // Проверка значений.
            if (checkNumber)
            {
                // Проверка числа на степень двойки и вывод результата.
                IsDegreeTwo(number);
            }
            // Вывод ошибки.
            else Console.WriteLine("wrong");


            Console.ReadLine();
        }
    }
}
