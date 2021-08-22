class Program
    {
        static int Power (int baseNum, int expo)
        {
            if (expo == 0)
            {
                return 1;
            }
            else
            {
                return baseNum * Power(baseNum, expo - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Exponent: ");
            int expo = int.Parse(Console.ReadLine());
            Console.WriteLine($"So, the number {baseNum}^{expo} = {Power(baseNum, expo)}"); 
        }
    }
