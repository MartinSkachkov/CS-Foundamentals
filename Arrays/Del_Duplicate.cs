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

            for (int i = 0; i < length; i++)
            {
                for (int j = i+1; j < length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        for (int k = j; k < length-1; k++)
                        {
                            arr[k] = arr[k + 1];
                        }
                        length--;
                    }
                }
            }

            Console.Write("Elements after deletion:");
            for (int i = 0; i < length; i++)
            {
                Console.Write(arr[i] +", ");
            }
        }
    }
