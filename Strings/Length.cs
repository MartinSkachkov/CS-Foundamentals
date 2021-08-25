class Program
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            //int count = text.Length;
            int count = 0;
            foreach (char symbol in text)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
