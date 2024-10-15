using System.Text;

namespace Sortowania
{
    public class Preparation
    {
        public static void fill(int[] array)
        {
            var rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);

            }
        }

        public static void display(int[] array)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i]);
                sb.Append(" ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
