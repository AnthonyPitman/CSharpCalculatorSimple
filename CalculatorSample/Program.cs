class CalculatorSample
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the calculator!");

        int accumulator = 0;

        Console.Write("Enter an initial value (press enter for 0): ");
        string input = Console.ReadLine();

        if (input != "")
        {
            accumulator = int.Parse(input);
        }

        Console.WriteLine($"Initial value: {accumulator}");

        do
        {
            Console.Write("Enter operation: ");
            string operation = Console.ReadLine();

            Console.Write("Enter operand (available operands: +, -, x, /): ");
            input = Console.ReadLine();
            int operand = int.Parse(input);

            switch (operation)
            {
                case "+":
                    accumulator += operand;
                    break;
                case "-":
                    accumulator -= operand;
                    break;
                case "x":
                case "*":
                    accumulator *= operand;
                    break;
                case "/":
                    accumulator /= operand;
                    break;
            }

            Console.WriteLine($"Current value: {accumulator}");

            Console.Write("Press enter to continue or 'quit' to stop: ");
            input = Console.ReadLine();
            input = input.ToLower();
        } while (input is not "quit" and not "q");

        Console.WriteLine("Thank you for using the calculator!");
    }
}
