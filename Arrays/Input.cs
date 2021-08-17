using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];
            int num;

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter element {i+1}: ");
                num = int.Parse(Console.ReadLine());
                arr[i] = num;
            }
            
            Console.Write("\nElements in array are: ");
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0}, ", arr[i]);
            }
        }
    }
}
