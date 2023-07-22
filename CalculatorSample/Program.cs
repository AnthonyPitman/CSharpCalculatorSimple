﻿namespace Calculator;
class CalculatorSample
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the calculator!");

        int accumulator = InitializeAccumulator();

        Console.WriteLine($"Initial value: {accumulator}");

        do
        {
            Operation operation = GetOperationFromUser();
            int operand = GetOperandFromUser();
            accumulator = CalculateNewValue(accumulator, operation, operand);

            Console.WriteLine($"Current value: {accumulator}");
        } while (ShouldContinue());

        Console.WriteLine("Thank you for using the calculator!");
    }

    private static int InitializeAccumulator()
    {
        string? input;
        int accumulator;
        do
        {
            Console.Write("Enter an initial value (press enter for 0): ");
            input = Console.ReadLine();
        } while (!int.TryParse(input, out accumulator) && input != "");

        return accumulator;
    }

    private static int GetOperandFromUser()
    {
        string input;
        int operand;

        do
        {
            Console.Write("Enter operand: ");
            input = Console.ReadLine() ?? "";
        } while (!int.TryParse(input, out operand));

        return operand;
    }

    private static Operation GetOperationFromUser()
    {
        Operation? operation;
        do
        {
            Console.Write("Enter operation (available operations: +, -, x, /): ");
            string input = Console.ReadLine() ?? "";
            input = input.Trim();

            operation = input switch
            {
                "+" => Operation.Add,
                "-" => Operation.Subtract,
                "*" or "x" => Operation.Multiply,
                "/" => Operation.Divide,
                _ => null,
            };
        } while (operation is null);

        return (Operation)operation; // operation being null is handled by the loop
    }

    private static int CalculateNewValue(int currentValue, Operation operation, int operand)
    {
#pragma warning disable CS8524
        int newValue = operation switch
#pragma warning restore CS8524
        {
            Operation.Add => currentValue + operand,
            Operation.Subtract => currentValue - operand,
            Operation.Multiply => currentValue * operand,
            Operation.Divide => currentValue / operand,
        };
        return newValue;
    }

    static bool ShouldContinue()
    {
        Console.Write("Press enter to continue or 'quit' to stop: ");
        string? input = Console.ReadLine();
        input = input?.ToLower();
        bool shouldContinue = input is not "quit" and not "q";
        return shouldContinue;
    }
}

public enum Operation
{
    Add,
    Subtract,
    Multiply,
    Divide
}
