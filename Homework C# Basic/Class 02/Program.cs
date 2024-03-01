// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        //exercise 01
        double doubleVar1 = 10.5;
        double doubleVar2 = 2.5;

        double doubleResult = doubleVar1 / doubleVar2;

        int intVar1 = 10;
        int intVar2 = 2;

        int intResult = intVar1 / intVar2;

        Console.WriteLine("Double Result: " + doubleResult);
        Console.WriteLine("Integer Result: " + intResult);
        
        //exercise 02
        string str1 = "Hello, ";
        string str2 = "world!";

        string concatStr1 = str1 + str2;

        string numStr1 = "9";
        string numStr2 = "3";

        string concatStr2 = numStr1 + numStr2;

        Console.WriteLine("Concatenated String 1: " + concatStr1);
        Console.WriteLine("Concatenated String 2: " + concatStr2);

        //exercise 03
        int num = 12;

        string str = "Test string,";

        string result = str + num;

        Console.WriteLine(result);

        //exercise 04

        int n = 102;
        int m = 5;

        float resultSms = n / m;

        Console.WriteLine("Total messages you can send:" +resultSms);

    }
}

