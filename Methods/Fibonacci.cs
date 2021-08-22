class Program
    {
        static int Fibo (int n)
        {
            int fib0 = 0;
            int fib1 = 1;
            int fibN = 0;

            for (int i = 1; i <= n; i++)
            {
                fibN = fib0 + fib1;
                fib0 = fib1;
                fib1 = fibN;
            }
            return fibN;
        }

        static void Main(string[] args)
        {
            Console.Write("Input number of Fibonacci Series: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Fibonacci series of {n} numbers is :");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibo(i)+ ", ");
            }
            Console.WriteLine();
        }
    }
