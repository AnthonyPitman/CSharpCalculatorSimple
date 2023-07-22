﻿class CalculatorSample
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the calculator!");

        int accumulator = 0;

        Console.Write("Enter an initial value (press enter for 0): ");
        string? input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input))
        {
            accumulator = int.Parse(input);
        }

        Console.WriteLine($"Initial value: {accumulator}");

        bool shouldContinue;

        do
        {
            Console.Write("Enter operation: ");
            string operation = Console.ReadLine() ?? "";

            Console.Write("Enter operand (available operands: +, -, x, /): ");
            input = Console.ReadLine() ?? "";
            int operand = int.Parse(input);

            accumulator = CalculateNewValue(accumulator, operation, operand);

            Console.WriteLine($"Current value: {accumulator}");
        } while (ShouldContinue());

        Console.WriteLine("Thank you for using the calculator!");
    }

    static int CalculateNewValue(int currentValue, string? operation, int operand)
    {
        int newValue;

        switch (operation)
        {
            case "+":
                newValue = currentValue + operand;
                break;
            case "-":
                newValue = currentValue - operand;
                break;
            case "x":
            case "*":
                newValue = currentValue * operand;
                break;
            case "/":
                newValue = currentValue / operand;
                break;
            default:
                newValue = currentValue;
                break;
        }

        return newValue;
    }

    static bool ShouldContinue()
    {
        Console.Write("Press enter to continue or 'quit' to stop: ");
        string? userInput = Console.ReadLine();
        userInput = userInput?.ToLower();
        bool shouldContinue = userInput is not "quit" and not "q";
        return shouldContinue;
    }
}
