class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter age(m/d/y)");
            DateTime myBirthday = DateTime.Parse(Console.ReadLine());
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
        }
    }
