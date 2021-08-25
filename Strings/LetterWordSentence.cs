class Program
    {
         public static void Main(string[] args)
        {
            Console.Write("Enter text:");
            string text = Console.ReadLine();
            int words = 1;
            int letters, sentence, digits;
            letters = sentence = digits = 0;

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
                if (text[i] == '!' || text[i] == '.' || text[i] == '?')
                {
                    sentence++;
                }
                if (text[i] >= '0' && text[i] <= '9')
                {
                    digits++;
                }
            }
            Console.WriteLine("Words: {0}", words);
            Console.WriteLine("Letters: {0}", letters);
            Console.WriteLine("Sentences: {0}", sentence);
            Console.WriteLine("Numbers: {0}", digits);

        }
    }
