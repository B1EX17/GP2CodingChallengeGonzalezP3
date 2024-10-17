using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Challenges
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my coding challenge program. There will be a variety of different functions you will have to choose from.    Please Pick One");

        Console.WriteLine("Today we are going to use the number pattern called Sum. Please Input two numbers for us to add. \n ");

        var number1 = Console.ReadLine();
        int number1int = int.Parse(number1);

        Console.WriteLine("Awesome! Please input a 2nd number");

        var number2 = Console.ReadLine();
        int number2int = int.Parse(number2);

        Console.WriteLine("The sum of the number: " + number1 + " and the number: " + number2 + " is equal to:" + Sum(number1int, number2int));

        Console.WriteLine(" Lets try converting minuts to seconds. \nGive me a number to convert from minutes to second");

        var number3 = Console.ReadLine();
        int number3int = int.Parse(number3);

        Console.WriteLine(number3 + " Minutes converted to seconds is " + Convert(number3int));

        Sum(number1int, number2int);

        Console.WriteLine(" Lets try adding one to any number");

        var number4 = Console.ReadLine();
        int number4int = int.Parse(number4);

        Console.WriteLine(number4 + " One added to the number selected is  " + PlusOne(number4int));

        // new script

        Console.WriteLine("Lets try converting voltage and current to power. \nGive me two numbers to convert from voltage and current to power");

        var number5 = Console.ReadLine();
        int number5int = int.Parse(number5);

        var number6 = Console.ReadLine();
        int number6int = int.Parse(number6);


        Console.WriteLine(Multiply(number5int, number6int));


        Console.WriteLine("Type in your age to see how many days you have lived");

        var number7 = Console.ReadLine();
        int number7int = int.Parse(number7);

        Console.WriteLine(Multiply(number7int));

        Console.WriteLine("Thats how many days you have lived!!");



        Console.WriteLine("Input the base of your triangle");

        var number8 = Console.ReadLine();
        int number8int = int.Parse(number8);

        Console.WriteLine("Input the Height of your triangle");
        var number9 = Console.ReadLine();
        int number9int = int.Parse(number9);

        Console.WriteLine("The area of the triangle with length: " + number8 + " and the Height:" + number9 + " is equal to: " + Triangle(number8int, number9int));

        //Determin if a number is less than or equal to zero
        Console.WriteLine("Type in a number to determine a value is equal to or less than \nGive me a number to determine if it is equal or less than zero");
        var number10 = Console.ReadLine();
        int number10int = int.Parse(number10);
        Console.WriteLine(number10 + " is equal to or less than zero: " + lessThanOrEqualToZero(number10int));




    }


    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public static int Convert(int number)
    {
        return number * 60;
    }

    public static int PlusOne(int number)
    {
        return number + 1;
    }

    public static int Multiply(int number5, int number6)
    {
        return number5 * number6;
    }

    public static int Multiply(int number7)
    {
        return number7 * 365;

    }

    public static float Triangle(float number8, int number9)
    {
        return (number8 * number9) / 2;
    }

    public static bool lessThanOrEqualToZero(int number)
    {
        return (number <= 0) ? true : false;
    }

}


    
