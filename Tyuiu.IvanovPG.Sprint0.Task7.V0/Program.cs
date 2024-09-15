using Tyuiu.IvanovPG.Sprint0.Task7.V0.Lib;

namespace Tyuiu.IvanovPG.Sprint0.Task7.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Иванов П.Г. | ИСТНБ-24-1";
            // Длина строки 75 символом 
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* спринт #0                                                                          *");
            Console.WriteLine("* Тема: создание Итогового решения по спринту                                        *");
            Console.WriteLine("* задание #7                                                                         *");
            Console.WriteLine("* вариант #0                                                                         *");
            Console.WriteLine("* выполнил: Иванов Прохор Геннадьевич | ИСТНБ-24-1     #0                            *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* Условие:                                                                           *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значение двух               *");
            Console.WriteLine("* одинаковых массивов по длине                                                       *");
            Console.WriteLine("*                                                                                    *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* Исходные данные:                                                                   *");
            Console.WriteLine("**************************************************************************************");


            // место решения задания
            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов массива №1");
            for (int i = 0; i < arrayNums1.Length; i++) 
            {
                Console.WriteLine(arrayNums1[i] + ", ");
            }

            Console.WriteLine();


            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива №2");
            for (int i = 0; i < arrayNums2.Length; i++) 
            {
                Console.WriteLine(arrayNums2[i] + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                          ");
            Console.WriteLine("**************************************************************************************");
            if (arrayNums1.Length == arrayNums2.Length) 
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

                Console.WriteLine("Сумма элементов массива ровна:");
                for  (int i = 0; i < resultArray.Length; i++) 
                {
                    Console.Write(resultArray[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");
            }
            Console.ReadKey();

        }
    }
}
