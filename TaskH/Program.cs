using System;


namespace TaskH
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
        /// Метод определения элементов суммы кубов
        /// </summary>
        /// <param name="number">Сумма кубов</param>
        static void GetSumCubs(int number)
        {
            // Массив для хранения элементов суммы.
            int[] CubsValueArray = new int[2];

            // Предел перебора.
            int limit = (int)Math.Sqrt(number);

            // Индикатор обнаружения элементов.
            bool isHave = false;

            // Поиск.
            for (int i = 0; i <= limit; i++)
            {
                for (int j = 0; j <= limit; j++)
                {
                    if (i * i * i + j * j * j == number)
                    {
                        CubsValueArray[0] = i;
                        CubsValueArray[1] = j;
                        isHave = true;
                        break;
                    }

                }
                if (isHave) break;
            }

            // Сортировка массива для вывода в порядке невозрастания.
            Array.Sort(CubsValueArray);

            // Вывод ответа.
            if (isHave) Console.WriteLine($"{CubsValueArray[1]} {CubsValueArray[0]}");
            else Console.WriteLine("impossible");

        }



        static void Main(string[] args)
        {
            bool checkNumber;


            // Ввод значений.
            int number = InputIntValue(Console.ReadLine(), out checkNumber);

            // Проверка значений.
            if (checkNumber && number >= 0 && number <= 1028)
            {
                // Поиск элементов суммы кубов и вывод результата.
                GetSumCubs(number);
            }
            // Вывод ошибки.
            else Console.WriteLine("wrong");


            Console.ReadLine();
        }
    }
}
