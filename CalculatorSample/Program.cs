namespace Calculator;
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
        int accumulator = 0;

        Console.Write("Enter an initial value (press enter for 0): ");
        string? input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input))
        {
            accumulator = int.Parse(input);
        }

        return accumulator;
    }

    private static int GetOperandFromUser()
    {
        Console.Write("Enter operand: ");
        string input = Console.ReadLine() ?? "";
        int operand = int.Parse(input);
        return operand;
    }

    private static Operation GetOperationFromUser()
    {
        Operation? operation;
        do
        {
            Console.Write("Enter operation (available operations: +, -, x, /): ");
            string input = Console.ReadLine() ?? "";

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
        int newValue = operation switch
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
