using Tyuiu.IvanovPG.Sprint0.Task6.V0.Lib;

namespace Tyuiu.IvanovPG.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            // пример циклической структуры находится в библиотеке классов в методе AdditionArray
            Console.WriteLine("Сумма Элементов массива = " + DataService.AdditionArray(numsArray));

            // пример циклической структуры находится в библиотеке классов в методе SubstractionArray
            Console.WriteLine("Разность Элементов массива = " + DataService.SubstractionArray(numsArray));

            // пример циклической структуры находится в библиотеке классов в методе MultiplicationArray
            Console.WriteLine("Произведение Элементов массива = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}
