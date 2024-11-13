using System;
using System.Runtime.InteropServices;


class Challenges
{
    public static void Main(string[] args)
    {
        bool continueProgram = true; // Declare the variable to control program loop

        while (continueProgram) // Start a loop to keep the program running
        {
            Console.WriteLine("\nWelcome to my coding challenge program.");
            Console.WriteLine("Please select a challenge from the list:");
            Console.WriteLine("1. Add two numbers (SUM)");
            Console.WriteLine("2. Convert minutes to seconds");
            Console.WriteLine("3. Add one to a number");
            Console.WriteLine("4. Calculate age in days");
            Console.WriteLine("5. Calculate the area of a triangle");
            Console.WriteLine("6. Determine if a number is less than or equal to zero");
            Console.WriteLine("7. Convert Voltage to Power");
            Console.WriteLine("8. Determine if the sum of two numbers is less then 100");
            Console.WriteLine("9. Determine if numbers are equal to each other");
            Console.WriteLine("10.Give me something");
            Console.WriteLine("11.The function reverses a boolean value");
            Console.WriteLine("12.Find how many seconds are in a hour");
            Console.WriteLine("13. Determine the sum of all the measures of the angles of an ___ sided polygon");



            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("You chose SUM. Please input two numbers.");
                    Console.Write("Enter first number: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"The sum of {num1} and {num2} is: {Sum(num1, num2)}");
                    break;
                case "2":
                    Console.WriteLine("You chose to convert minutes to seconds.");
                    Console.Write("Enter the number of minutes: ");
                    int minutes = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{minutes} minutes is equal to {Convert(minutes)} seconds.");
                    break;
                case "3":
                    Console.WriteLine("You chose to add one to a number.");
                    Console.Write("Enter a number: ");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Adding one to {number} gives: {PlusOne(number)}");
                    break;
                case "4":
                    Console.WriteLine("You chose to calculate age in days.");
                    Console.Write("Enter your age in years: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{age} years is approximately {CalcAge(age)} days.");
                    break;
                case "5":
                    Console.WriteLine("You chose to calculate the area of a triangle.");
                    Console.Write("Enter the base of the triangle: ");
                    float baseLength = float.Parse(Console.ReadLine());
                    Console.Write("Enter the height of the triangle: ");
                    int height = int.Parse(Console.ReadLine());
                    Console.WriteLine($"The area of the triangle is: {TriArea(baseLength, height)}");
                    break;
                case "6":
                    Console.WriteLine("You chose to determine if a number is less than or equal to zero.");
                    Console.Write("Enter a number: ");
                    int inputNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{inputNumber} is less than or equal to zero: {LessThanOrEqualToZero(inputNumber)}");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a valid challenge from the list.");
                    break;
                case "7":

                    Console.WriteLine("Lets try converting voltage and current to power. \nGive me two numbers to convert from voltage and current to power");

                    var number1 = Console.ReadLine();
                    int number1int = int.Parse(number1);

                    var number2 = Console.ReadLine();
                    int number2int = int.Parse(number2);


                    Console.WriteLine(Voltage(number1int, number2int));
                    break;
                case "8":
                    Console.WriteLine("Determine if the sum of a number is Less than 100");
                    Console.Write("Enter first number:");
                    var number9 = Console.ReadLine();
                    int number9int = int.Parse(number9);
                    Console.Write("Enter second number:");
                    var number10 = Console.ReadLine();
                    int number10int = int.Parse(number10);

                    Console.WriteLine(LessThan100(number9int, number10int));
                    break;

                case "9":
                    Console.WriteLine("Determine if numbers are equal to each other");
                    Console.Write("Enter first number:");
                    var number11 = Console.ReadLine();
                    int number11int = int.Parse(number11);
                    Console.Write("Enter second number:");
                    var number12 = Console.ReadLine();
                    int number12int = int.Parse(number12);

                    Console.WriteLine(IsEqual(number11int, number12int));
                    break;
                case "10":
                    Console.WriteLine("Add Something to Anything");
                    Console.Write("Something added to:");
                    string phrase = Console.ReadLine();

                    Console.WriteLine(GiveMeSomething(phrase));
                    break;

                case "11":
                    Console.WriteLine("Lets reverse a boolean");
                    var trueorfalse = Console.ReadLine();

                    if (trueorfalse == "true")
                    {
                        Console.WriteLine("Its False");
                    }
                    else if (trueorfalse == "false")
                    {
                        Console.WriteLine("Its True");
                    }
                    else
                    {
                        Console.WriteLine("Try again you mispelled something");
                    }

                    break;
                case "12":
                    Console.WriteLine("You chose to convert minutes to seconds.");
                    Console.Write("Enter the number of hours: ");
                    int seconds = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{seconds} is equal to {howManySeconds(seconds)} seconds.");
                    break;

                case "13":
                    Console.WriteLine("You choose to determine the sum all measure of the angles of am n-sided Polygon. ");
                    Console.Write("Enter the number sides on the regular poligan ");


                    int n = int.Parse(Console.ReadLine());
                    if (n <= 2)
                    {
                        Console.WriteLine("The number is less than 2 ");
                    }
    
                    
                    else if (n > 2)
                    {
                        Console.WriteLine($"{n} returning the sum of internal angles is {SumPolygon(n)}.");
                    }
                    break;


            }

            // Ask if the user wants to try another challenge
            Console.WriteLine("\nWould you like to try another challenge? (y/n)");
            string continueChoice = Console.ReadLine().ToLower();
            if (continueChoice != "y")
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                continueProgram = false; // Ends the loop if user says 'n'
            }
        }
    }

    // Challenge methods
    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public static int Convert(int minutes)
    {
        return minutes * 60;
    }

    public static int PlusOne(int number)
    {
        return number + 1;
    }

    public static int CalcAge(int years)
    {
        return years * 365;
    }

    public static float TriArea(float baseLength, int height)
    {
        return (baseLength * height) / 2;
    }

    public static bool LessThanOrEqualToZero(int number)
    {
        return number <= 0;
    }
    public static int Voltage(int number1, int number2)
    {
        return number1 * number2;
    }

    public static bool LessThan100(int number9, int number10)
    {
        return number9 + number10 < 100;
    }

    public static bool IsEqual(int number11, int number12)
    {
        return number11 <= number12;
    }


    public static string GiveMeSomething(string phrase)
    {
        return "Something" + phrase;
    }

    public static int howManySeconds(int seconds)
    {
        return seconds * 3600;
    }

    public static int SumPolygon(int n)
    {
        return (n - 2) * 180;
    }


}







