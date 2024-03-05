namespace Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Marko", "Darko", "Janko", "Ranko", "Vlado" };

            Console.Write("Enter student group (1 or 2): ");
            int groupNumber = Convert.ToInt32(Console.ReadLine());

            if (groupNumber == 1)
            {
                Console.WriteLine("Students in group 1:");
                foreach (string student in studentsG1)
                {
                    Console.WriteLine(student);
                }
            }
            else if (groupNumber == 2)
            {
                Console.WriteLine("Students in group 2:");
                foreach (string student in studentsG2)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("Invalid group number. Please enter 1 or 2.");
            }
        }
    }
}
        
