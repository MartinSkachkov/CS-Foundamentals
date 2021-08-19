static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1]) // за намаляващо ще е arr[j] < arr[j+1]
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 6, -9, 35, 41, 26, -26, -45, 18 };
            BubbleSort(arr);
            PrintArray(arr);

        }
