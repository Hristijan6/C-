namespace class03exercise02Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numbers from 1 to " + num1 + ":");
            for (int i = 1; i <= num1; i++)
            {
                Console.WriteLine(i + " ");
            }

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numbers from " + num2 + " to 1:");
            for (int i = num2; i >= 1; i--)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
