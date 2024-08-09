Console.WriteLine("Welcome to the Exponent Lab");

//setup the loop
bool runProgram = true;

do
{
    int value = GetInput();
    Console.WriteLine(String.Format("{0,7} {1,7} {2,7}", "Number", "Squared", "Cubed"));
    Console.WriteLine(String.Format("{0,7} {1,7} {2,7}", "=======", "=======", "======="));
    for (int r = 1; r <= value; r++)
    {
        int number = r; // redundant just use r
        int squared = GetSquared(r); // redundant use method(r)
        int cubed = GetCubed(r); // redundant use method(r)
        Console.WriteLine(String.Format("{0,7} {1,7} {2,7}", number, squared, cubed));
    }
    runProgram = GetContinue();
} while (runProgram);

//methods
static int GetInput()
{
    int result = -1;
    while(result <= 0 || result > 1290)
    {
        Console.WriteLine("Please enter a positive number.");
        result = int.Parse(Console.ReadLine());
        if(result <= 0)
        {
            Console.WriteLine("Number is not positive.");
        }
        if(result > 1290)
        {
            Console.WriteLine("Number cannot be cubed in C#.");
        }
    }
    return result;
}


static bool GetContinue()
{
    bool result = true;
    while (true)
    {
        Console.WriteLine("Would you like to continue? y/n");
        string continueChoice = Console.ReadLine();
        if (continueChoice == "y")
        {
            result = true;
            break;
        }
        else if (continueChoice == "n")
        {
            result = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid choice. Try again.");
        }
    }
    return result;
}

static int GetSquared(int x)
{
    return x * x;
}

static int GetCubed(int x)
{
    return x * x * x;
}