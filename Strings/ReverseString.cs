class Program
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            //char[] chr = text.ToCharArray();
            //Array.Reverse(chr);
            //Console.WriteLine(chr);
            for (int i = text.Length-1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine();
        }
    }
