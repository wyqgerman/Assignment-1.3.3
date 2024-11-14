namespace Assignment_1._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to store in the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine($"Input {n} number of elements in the array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"element - {i} : ");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n / 2; i++)
            {
                int temp = array[i];
                array[i] = array[n - i - 1];
                array[n - i - 1] = temp;
            }

            Console.WriteLine("\nThe values stored into the array in reverse order are:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
