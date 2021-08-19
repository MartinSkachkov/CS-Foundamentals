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

            Console.Write("Reversed:");
            for (int i = length-1; i >= 0; i--)
            {
                Console.Write(arr[i] + ", ");
            }
        }
    }
