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

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter element {i+1}: " );
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Negative elements:");
            for (int i = 0; i < length; i++)
            {
                if (arr[i] < 0)
                {
                    Console.Write(arr[i] + ", ");
                }
            }
        }
    }
}
