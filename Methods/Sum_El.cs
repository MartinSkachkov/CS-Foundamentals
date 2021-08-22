class Program
    {
        static int SumElements (int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Element {i+1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine($"Sum: {SumElements(arr)}"); 
        }
    }
