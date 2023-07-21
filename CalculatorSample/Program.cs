Console.WriteLine("Welcome to the calculator!");

int accumulator = 0;
string input;

Console.WriteLine("Initial value: " + accumulator);

do
{
    // Get operation from user
    Console.Write("Enter operation: ");
    string operation = Console.ReadLine();

    // Get operand from user
    Console.Write("Enter operand: ");
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
            accumulator *= operand;
            break;
        case "/":
            accumulator /= operand;
            break;
    }

    Console.WriteLine("Current value: " + accumulator);

    Console.Write("Press enter to continue or 'quit' to stop: ");
    input = Console.ReadLine();
} while (input != "quit");

Console.WriteLine("Thank you for using the calculator!");
