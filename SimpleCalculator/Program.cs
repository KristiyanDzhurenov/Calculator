// Welcome the user
Console.WriteLine("Welcome to the calculator!");

// Input the first num
Console.Write("Please enter the first number: ");
double num1 = double.Parse(Console.ReadLine());

// Input the second num
Console.Write("Please enter the second number: ");
double num2 = double.Parse(Console.ReadLine());

// Entering the operation
Console.Write("Please select an operation (+, -, *, /):");
string operationInput = Console.ReadLine();

    // Variable to store the result
    double result = 0;

    // Perform the operation
    switch (operationInput)
    {
        case "+":
            result = num1 + num2;
            break;
        case "-":
            result = num1 - num2;
        break;
        case "*":
            result = num1 * num2;
            break;
        case "/":
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Error: Division by zero not possible.");
                return; // Stopping the program
            }
            break;
        default:
            Console.WriteLine("Invalid operation!");
            return; // Stopping the program
    }

    // Outputting the result
    Console.WriteLine($"Result: {num1} {operationInput} {num2} = {result}");
if (operationInput.Length > 0)
{
    char operation = operationInput[0];
}
else
{
    Console.WriteLine("You have not entered an operation! Please try again.");
}