class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter text:");
            string text = Console.ReadLine();
            Console.Write("Enter 2 text:");
            string text2 = Console.ReadLine();
            bool same = false;

            if (text.Length == text2.Length)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == text2[i])
                    {
                        same = true;
                    }
                }

                if (same == true)
                {
                    Console.WriteLine("The length of both strings are equal and " +
                        "also, both strings are equal.");
                }
                else
                {
                    Console.WriteLine("Not equal");
                }
            }
            if (text.Length != text2.Length)
            {
                Console.WriteLine("Not equal");
            }
            
        }
    }
