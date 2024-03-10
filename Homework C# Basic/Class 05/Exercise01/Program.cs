namespace Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday (dd.MM.yyyy):");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime birthday))
            {
                int age = AgeCalculator(birthday);
                Console.WriteLine($"You are {age} years old.");
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }
        }

        static int AgeCalculator(DateTime birthday)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthday.Year;
            if (birthday.Date > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}
