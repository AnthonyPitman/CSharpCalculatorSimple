Console.WriteLine("Welcome to the calculator!");

Console.Write("Enter an initial value: ");
string input = Console.ReadLine();
int accumulator = int.Parse(input);

Console.WriteLine("Initial value: " + 0);

do
{
    // Get operation from user
    Console.Write("Enter operation: ");
    string operation = Console.ReadLine();

    // Get operand from user
    Console.Write("Enter operand (availabled operands: +, -, x, /): ");
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

    Console.WriteLine("Current value: " + 0);

    Console.Write("Press enter to continue or 'quit' to stop: ");
    input = Console.ReadLine();
} while (input != "quit");

Console.WriteLine("Thank you for using the calculator!");
