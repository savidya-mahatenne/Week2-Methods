CreateMenu();

void CreateMenu()  
{
    try
    {
        // Construct the menu
        Console.Clear();
        Console.WriteLine("Main Menu");
        Console.WriteLine("1. Say Hello");
        Console.WriteLine("2. Add Numbers");
        Console.WriteLine("3. Exit");
        Console.Write("Choose an option: ");

        // Accept the user's choice
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                SayHello();
                break;
            case "2":
                AddNumbers();
                break;
            case "3":
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    catch (Exception ex)
    {
        Console.WriteLine($"Error. {ex.Message}");
    }
}

static void SayHello()
{
    Console.WriteLine("Hello World!");
}

static void AddNumbers()
{
    Console.WriteLine("Enter the first number: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the second number: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    int result = firstNumber + secondNumber;
    Console.WriteLine($"The result is: {result}");
}


// second part of tutorial - not necessary to type
// Main();

void Main()
{
    try
    {
        Console.WriteLine("Please enter the rectangle length");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter rectangle width");
        double width = Convert.ToDouble(Console.ReadLine());

        // Calling the method and storing the result
        double area = CalculateArea(length, width);

        // Output the result
        Console.WriteLine($"The area of the rectangle is: {area}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}

// Method declaration
// 'CalculateArea' is the method name
// 'double' is the return type
// 'double length' and 'double width' are parameters
static double CalculateArea(double length, double width)
{
    // Method body
    double area = length * width;
    return area; // Returning the calculated area
}
