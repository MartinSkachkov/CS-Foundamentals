class Program
    {
        static int Sum (int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
            //Console.WriteLine($"Sum: {sum}");
        }

        static void Main(string[] args)
        {
            Console.Write("num 1: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("num 2: ");
            int num2 = int.Parse(Console.ReadLine());
            //Sum(num, num2);
            Console.WriteLine($"Sum: {Sum(num, num2)}") ;
        }
    }
