class Program
    {
        static int fact (int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * fact(n - 1);
            }

        }

        static void Main(string[] args)
        {
            Console.Write("number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"The factorial of {n}! is {fact(n)}");
        }
    }
