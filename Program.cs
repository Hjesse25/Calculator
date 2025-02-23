bool exit = false;

Console.WriteLine("-------- Console Calculator App --------");
do
{
    try
    {
        Console.WriteLine("Enter a number based on desired operation");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");
        Console.WriteLine("5. Modulo");
        Console.WriteLine("6. Exit");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 6)
        {
            exit = true;
            return;
        }

        Console.Write("Enter first number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        double result;

        switch (choice)
        {
            case 1:
                result = firstNumber + secondNumber;
                Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
                break;
            case 2:
                result = firstNumber - secondNumber;
                Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
                break;
            case 3:
                result = firstNumber * secondNumber;
                Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
                break;
            case 4:
                if (secondNumber == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                else
                {
                    result = firstNumber / secondNumber;
                    Console.WriteLine($"{firstNumber} + {secondNumber} equals {result}");
                }
                break;
            case 5:
                result = firstNumber % secondNumber;
                Console.WriteLine($"{firstNumber} % {secondNumber} equals {result}");
                break;
        }

        PressEnter();
    }
    catch (Exception)
    {
        Console.WriteLine("Invalid input, please try again.");
        PressEnter();
    }

} while (exit != true);

static void PressEnter()
{
    Console.Write("Press enter to continue: ");
    string enterInput = Console.ReadLine();
    Console.Clear();
}
