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

            Console.Write("Enter element to search: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                 if (arr[i] == num)
                 {
                    Console.WriteLine($"Found {num} at position {i+1}");
                    break;
                 }   
            }  
        }
    }
