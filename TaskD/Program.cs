using System;

namespace TaskD
{
    class Program
    {

        

        /// <summary>
        /// Метод считывания целочисленных значений
        /// </summary>
        /// <param name="inputString">Строка, которую нужно преобразовать в int</param>
        /// <param name="checkNumber">Индикатор успешного выполнения преобразования</param>
        /// <returns>Целочисленное значение</returns>
        static int InputIntValue(string inputString, out bool checkNumber)
        {
            int number;
            if(int.TryParse(inputString, out number))
            {
                checkNumber = true;
                return number;
            }
            checkNumber = false;
            return 0;
        }





        /// <summary>
        /// Метод, проверяющий на существование треугольника
        /// </summary>
        /// <param name="firstTL">Первая сторона треугольника</param>
        /// <param name="secondTL">Вторая сторона треугольника</param>
        /// <param name="thirdTL">Третья сторона треугольника</param>
        /// <returns>Значение типа bool</returns>
        static bool IsTriangle(int firstTL, int secondTL, int thirdTL)
        {
            int counterTrueValue = 0;
            counterTrueValue = (firstTL + secondTL) > thirdTL ? counterTrueValue + 1 : 0;
            counterTrueValue = (firstTL + thirdTL) > secondTL ? counterTrueValue + 1 : 0;
            counterTrueValue = (secondTL + thirdTL) > firstTL ? counterTrueValue + 1 : 0;
            return counterTrueValue == 3;
        }





        /// <summary>
        /// Метод определения типа треугольника
        /// </summary>
        /// <param name="firstTriangeLen">Первая сторона треугольника</param>
        /// <param name="secondTriangeLen">Вторая сторона треугольника</param>
        /// <param name="thirdTriangeLen">Третья сторона треугольника</param>
        /// <returns>Строка, содержащая тип треугольника</returns>
        static string IsTypeTriangle(int firstTriangeLen, int secondTriangeLen, int thirdTriangeLen)
        {
            int[] TriangeLenArray = new int[3];
            // Заполнение массива сторонами треугольника.
            TriangeLenArray[0] = firstTriangeLen;
            TriangeLenArray[1] = secondTriangeLen;
            TriangeLenArray[2] = thirdTriangeLen;
            // Сортировка массива.
            Array.Sort(TriangeLenArray);

            string answer;
            // Определение типа треугольника.
            int hypotSquare = TriangeLenArray[2] * TriangeLenArray[2];
            int cathetsSquare = TriangeLenArray[0] * TriangeLenArray[0] + TriangeLenArray[1] * TriangeLenArray[1];

            answer = hypotSquare < cathetsSquare ? "acute" : "obtuse";
            answer = hypotSquare == cathetsSquare ? "right" : "right";

            return answer;
        }





        /// <summary>
        /// Метод вывода надписи impossible
        /// </summary>
        /// <returns>Строка impossible</returns>
        static string ImpossibleMessage()
        {
            return "impossible";
        }





        static void Main(string[] args)
        {
            bool checkFirstTriangeLen, checkSecondTriangleLen, checkThirdTriangeLen;

            // Ввод значений.
            int firstTriangeLen = InputIntValue(Console.ReadLine(), out checkFirstTriangeLen);
            int secondTriangeLen = InputIntValue(Console.ReadLine(), out checkSecondTriangleLen);
            int thirdTriangeLen = InputIntValue(Console.ReadLine(), out checkThirdTriangeLen);

            // Проверка значений на преобразование в int.
            if (checkFirstTriangeLen && checkSecondTriangleLen && checkSecondTriangleLen)
            {
                string answer;

                answer = IsTriangle(firstTriangeLen, secondTriangeLen, thirdTriangeLen) ?
                    IsTypeTriangle(firstTriangeLen, secondTriangeLen, thirdTriangeLen) : ImpossibleMessage();

                // Вывод результата.
                Console.WriteLine(answer);
            }
            // Вывод ошибки.
            else Console.WriteLine("wrong");

            Console.ReadLine();

        }
    }
}
