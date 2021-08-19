static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j]) //за намаляващ arr[i] < arr[j]
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
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
            SelectionSort(arr);
            PrintArray(arr);
        }
