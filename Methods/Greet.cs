class Program
    {
        static void Greet (string name)
        {
            Console.WriteLine($"Welcome friend {name} ! \nHave a nice day!");
        }

        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Greet(name);
        }
    }
