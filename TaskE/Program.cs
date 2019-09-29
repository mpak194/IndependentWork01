using System;


namespace TaskE
{
    class Program
    {

        /// <summary>
        /// Метод считывания целочисленных значений
        /// </summary>
        /// <param name="inputString">Строка, которую необходимо преобразовать в int</param>
        /// <param name="checkNumValue">Индикатор успешности выполнения операции</param>
        /// <returns>Целочисленное значение int</returns>
        static int InputIntValue(string inputString, out bool checkNumValue)
        {
            int number;
            if (int.TryParse(inputString, out number))
            {
                checkNumValue = true;
                return number;
            }
            checkNumValue = false;
            return 0;
        }



        /// <summary>
        /// Метод для вычисления количества равных из трех
        /// </summary>
        /// <param name="value1">Первое число</param>
        /// <param name="value2">Второе число</param>
        /// <param name="value3">Третье число</param>
        /// <returns>Количество равных чисел из трех</returns>
        static int CounterIdenticalNumber(int value1, int value2, int value3)
        {
            // Заполнение массива тремя числами.
            int[] NumValueArray = new int[3];
            NumValueArray[0] = value1;
            NumValueArray[1] = value2;
            NumValueArray[2] = value3;

            Array.Sort(NumValueArray);


            if (NumValueArray[0] == NumValueArray[1] && NumValueArray[1] == NumValueArray[2]) return 3;
            else if (NumValueArray[0] == NumValueArray[1] && NumValueArray[1] != NumValueArray[2]) return 2;
            else if (NumValueArray[0] != NumValueArray[1] && NumValueArray[1] == NumValueArray[2]) return 2;
            else return 0;
        }




        static void Main(string[] args)
        {
            bool checkNumValue1, checkNumValue2, checkNumValue3;

            // Ввод значений.
            int numValue1 = InputIntValue(Console.ReadLine(), out checkNumValue1);
            int numValue2 = InputIntValue(Console.ReadLine(), out checkNumValue2);
            int numValue3 = InputIntValue(Console.ReadLine(), out checkNumValue3);

            if (checkNumValue1 && checkNumValue2 && checkNumValue3)
            {
                // Вычисление количества равных из трех
                int totalIdenticalNum = CounterIdenticalNumber(numValue1, numValue2, numValue3);

                // Вывод результата
                Console.WriteLine(totalIdenticalNum);
            }
            // Вывод ошибки.
            else Console.WriteLine("wrong");


            Console.ReadLine();



        }
    }
}
