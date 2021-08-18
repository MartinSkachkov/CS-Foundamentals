class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            int countEven =0, countOdd = 0;

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter element {i+1}: " );
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }

            Console.WriteLine($"Even: {countEven}");
            Console.WriteLine($"Odd: {countOdd}");
        }
    }
