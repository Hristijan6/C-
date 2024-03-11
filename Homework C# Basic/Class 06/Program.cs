namespace Class06Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dog's name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the dog's breed:");
            string breed = Console.ReadLine();

            Console.WriteLine("Enter the dog's color:");
            string color = Console.ReadLine();

            Dog dog = new Dog { DogName = name, DogBreed = breed, DogColor = color };

            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Eat");
            Console.WriteLine("2. Play");
            Console.WriteLine("3. Chase Tail");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(dog.Eat());
                        break;
                    case 2:
                        Console.WriteLine(dog.Play());
                        break;
                    case 3:
                        Console.WriteLine(dog.ChaseTail());
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
