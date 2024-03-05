namespace Exercise04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[0]; 

            string choice;
            do
            {
                Console.Write("Enter a name: ");
                string newName = Console.ReadLine();

                Array.Resize(ref names, names.Length + 1);
                names[names.Length - 1] = newName;

                Console.Write("Do you want to enter another name? (y/n): ");
                choice = Console.ReadLine();
            } while (choice.ToLower() == "y");

            Console.WriteLine("All names entered:");
            foreach (string name in names)
            {
                Console.WriteLine(name);

            }
        }
    }
}
