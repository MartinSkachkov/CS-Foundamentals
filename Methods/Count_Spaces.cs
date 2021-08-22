class Program
    {
        static int SpaceCount (string text)
        {
            int spaces = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    spaces++;
                }
            }
            return spaces;
        }

        static void Main(string[] args)
        {
            Console.Write("enter text: ");
            string text = Console.ReadLine();
            Console.WriteLine($"Spaces: {SpaceCount(text)}");

        }
    }
