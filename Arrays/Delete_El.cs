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

            Console.Write("Position to delete:");
            int position = int.Parse(Console.ReadLine());

            for (int i = position - 1; i < length -1; i++)
            {
                arr[i] = arr[i + 1];
            }
            length--;

            Console.Write("Elements after insertion:");
            for (int i = 0; i < length; i++)
            {
                Console.Write(arr[i] +", ");
            }
        }
    }
