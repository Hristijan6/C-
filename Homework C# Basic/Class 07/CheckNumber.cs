namespace Class07Exercise01
{
    public class CheckNumber
    {

        public void NumberStats(double number)
        {
            string positiveOrNegative = "";
            if (number > 0)
            {
                positiveOrNegative = "Positive";

            }
            else if (number < 0)
            {
                positiveOrNegative = "Negative";

            }
            else if (number == 0)
            {
                positiveOrNegative = "(0)";
            }

            string decimalOrInteger = "";

            if (number % 1 == 0)
            {
                decimalOrInteger = "Integer";

            }
            else if (number % 1 != 0)
            {
                decimalOrInteger = "Decimal";
            }

            string oddOrEven = "";
            if (decimalOrInteger == "Integer")
            {
                if (number % 2 == 0)
                {
                    oddOrEven = "Even";

                }
                else if (number % 2 != 0)
                {
                    oddOrEven = "Odd";
                }
            }
            else if (decimalOrInteger == "Decimal")
            {
                oddOrEven = "Decimals arent odd or even";
            }


            Console.WriteLine("");
            Console.WriteLine($"Statistics for number: {number}");
            Console.WriteLine($"{positiveOrNegative}");
            Console.WriteLine($"{decimalOrInteger}");
            Console.WriteLine($"{oddOrEven}");
        }
    }
}

    

