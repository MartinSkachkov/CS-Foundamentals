class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter text:");
            string text = Console.ReadLine();
            int words = 1;
            int letters = 0;
            int sentence = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    words++;
                }
                if (text[i] != ' ' && text[i] != '!' && text[i] != '.' && text[i] != '?')
                {
                    letters++;
                }
                if (text[i] == '!'|| text[i] == '.' || text[i] == '?')
                {
                    sentence++;
                }
            }
            Console.WriteLine("Words: {0}",words);
            Console.WriteLine("Letters: {0}", letters);
            Console.WriteLine("Sentences: {0}", sentence);
        }
    }
