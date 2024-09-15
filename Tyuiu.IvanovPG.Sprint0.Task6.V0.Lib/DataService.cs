namespace Tyuiu.IvanovPG.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        // пример циклической структуры (цикл с парметром)  for
        public static object AdditionArray(int[] number)
        {
            var total = 0;
            for (var i = 0; i < number.Length; i++)
            {
                total = total + number[i];
            }
            return total;

        }
        // пример циклической структуры (цикл с предусловием) while 
        public static object SubstractionArray(int[] number)
        {
            var total = 0;
            var index = 0;


            while (index < number.Length)
            {
                total = total - number[index];
                index++;
            }
            return (total);
        }

        // пример циклической структуры (цикл с постусловием) do while 
        public static object MultiplicationArray(int[] number)
        {
            var total = 1;
            var index = 0;
            do
            {
                total = total * number[index];
                index++;
            }
            while (index < number.Length);


            return total;
        }
    }
}
