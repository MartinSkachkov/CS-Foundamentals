class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            int min, max;

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter element {i+1}: " );
                arr[i] = int.Parse(Console.ReadLine());
            }

            min = arr[0];
            max = arr[0];

            for (int i = 0; i < length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
                else if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
        }
    }
