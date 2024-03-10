namespace Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Substrings(n);
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
        }

        static void Substrings(int n)
        {
            string glaven = "Hello from SEDC Codeacademy 2024";
            if (n >= 0 && n <= glaven.Length)
            {
                string pomosen = glaven.Substring(0, n);
                Console.WriteLine($"First {n} characters: {pomosen}");
                Console.WriteLine($"Length of the new string: {pomosen.Length}");
            }
            else
            {
                Console.WriteLine("Invalid number. Please enter a number within the range of the string length.");
            }
        }        
    }
}
