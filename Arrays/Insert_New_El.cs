class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length + 1];

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter element {i+1}: " );
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Element to insert:");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Position:");
            int position = int.Parse(Console.ReadLine());

            for (int i = length; i >= position; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[position - 1] = num;
            length++;

            Console.Write("Elements after insertion:");
            for (int i = 0; i < length; i++)
            {
                Console.Write(arr[i] +", ");
            }
        }
