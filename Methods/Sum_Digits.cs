class Program
    {
        static int Sum (int n)
        {
            int m;
            int sum = 0;
            while (n>0)
            {
                m = n % 10;
                sum += m;
                n = n / 10;
            }
            return sum;

        }

        static void Main(string[] args)
        {
            Console.Write("number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum:{Sum(n)}");
        }
    }
