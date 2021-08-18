class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            int max1, max2;

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter element {i+1}: " );
                arr[i] = int.Parse(Console.ReadLine());
            }

            max1 = max2 = arr[0];

            for (int i = 0; i < length; i++)
            {
                if (arr[i] > max1)
                {
                    max2 = max1;
                    max1 = arr[i];
                }
                else if (arr[i] > max2 && arr[i] < max1)
                {
                    max2 = arr[i];
                }
            }
            Console.WriteLine($"Max1: {max1}");
            Console.WriteLine($"Max2: {max2}");
        }
    }
