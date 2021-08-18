using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            int count = 0;

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter element {i+1}: " );
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] < 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Total negative elements: {count}");
        }
    }
}
