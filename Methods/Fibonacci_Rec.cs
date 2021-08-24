class Program
    {
        public static int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }
    }
