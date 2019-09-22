using System;

namespace TaskC
{
    class Program
    {
        /// <summary>
        /// Метод для ввода значений типа int
        /// </summary>
        /// <param name="inputSting">Строка, которую необходимо преобразовать в int</param>
        /// <param name="checkNumber">Индикатор успешности преобразования</param>
        /// <returns>Значение типа int</returns>
        static int InputIntValue(string inputSting, out bool checkNumber)
        {
            int number;
            if(int.TryParse(inputSting, out number))
            {
                checkNumber = true;
                return number;
            }
            checkNumber = false;
            return 0;
        }


        /// <summary>
        /// Метод перевода десятка числа в римскую СС
        /// </summary>
        /// <param name="number">Число десятков, которые нужно привести к римской форме</param>
        /// <param name="answer">Строка, куда сохраняется результат</param>
        static void ConvertTensToRome(int number, ref string answer)
        {
            switch(number)
            {
                case 0:
                    break;
                case 1:
                    answer = "X";
                    break;
                case 2:
                    answer = "XX";
                    break;
                case 3:
                    answer = "XXX";
                    break;
                case 4:
                    answer = "XL";
                    break;
                case 5:
                    answer = "L";
                    break;
                case 6:
                    answer = "LX";
                    break;
                case 7:
                    answer = "LXX";
                    break;
                case 8:
                    answer = "LXXX";
                    break;
                case 9:
                    answer = "XC";
                    break;
                case 10:
                    answer = "C";
                    break;

            }
        }




        /// <summary>
        /// Метод перевода единицы числа в римскую СС
        /// </summary>
        /// <param name="number">Число единиц, которые нужно привести к римской форме</param>
        /// <param name="answer">Строка, куда сохраняется результат</param>
        static void ConvertOnesToRome(int number, ref string answer)
        {
            switch (number)
            {
                case 0:
                    break;
                case 1:
                    answer += "I";
                    break;
                case 2:
                    answer += "II";
                    break;
                case 3:
                    answer += "III";
                    break;
                case 4:
                    answer += "IV";
                    break;
                case 5:
                    answer += "V";
                    break;
                case 6:
                    answer += "VI";
                    break;
                case 7:
                    answer += "VII";
                    break;
                case 8:
                    answer += "VIII";
                    break;
                case 9:
                    answer += "IX";
                    break;

            }
        }




        static void Main(string[] args)
        {
            bool checkNumber;
            // Ввод значений.
            int number = InputIntValue(Console.ReadLine(), out checkNumber);


            // Проверка допустимых значений.
            if(checkNumber && number >= 1 && number <= 100)
            {
                // Нахождение числа десятка и единиц числа.
                int tensNumber, onesNumber;
                onesNumber = number % 10;
                tensNumber = number / 10;
                
                // Преобразование в римскую СС.
                string answer = string.Empty;
                ConvertTensToRome(tensNumber, ref answer);
                ConvertOnesToRome(onesNumber, ref answer);

                // Вывод результата.
                Console.WriteLine(answer);
            }
            // Вывод ошибки.
            else Console.WriteLine("wrong");


            Console.ReadLine();
        }
    }
}
