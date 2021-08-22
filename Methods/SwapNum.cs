class Program
    {
        static void SwapNum (int num1, int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"Now the 1st number is : {num1}, and the 2nd number is : {num2}");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = int.Parse(Console.ReadLine());
            SwapNum(num1, num2);
        }
    }
