// You need to create a game that consists of asking the player what's the result of a math question (i.e. 9 x 9 = ?), 
//      collecting the input and adding a point in case of a correct answer.
// A game needs to have at least 5 questions.
// The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. 
//      Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.
// Users should be presented with a menu to choose an operation
// You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.
// You don't need to record results on a database. Once the program is closed the results will be deleted.

// :: gives user a clean menu to choose from for selecting a type of game

// TODO
// add division game (make sure dividends are divisible)
// figure out how to record games in list and add menu option to view previous games 

List<string> results = new List<string>();

static void Menu(List<string> results)
{
    string? userInput = "";

    do
    {
        Console.WriteLine("What operation would you like to use? (choose a number)");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. View Previous Games");
        userInput = Console.ReadLine();
    } while (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4" && userInput != "5");

    if (userInput == "1")
    {
        AdditionGame(results);
    }
    else if (userInput == "2")
    {
        SubtractionGame(results);
    }
    else if (userInput == "3")
    {
        MultiplicationGame(results);
    }
    else if (userInput == "4")
    {
        DivisionGame(results);
    } 
    else if (userInput == "5")
    {
        ViewGames(results);    
    }
}

Menu(results);

static int generateNumber()
{
    Random rnd = new Random();
    int randomNumber = rnd.Next(1, 101);

    return randomNumber;
}

static void ViewGames(List<string> results)
{
    foreach(string result in results)
    {
        Console.WriteLine(result);
    }
    Console.WriteLine("Press enter to return to the menu");
    Console.ReadLine();
    Menu(results);
}

static void AdditionGame(List<string> results)
{
    Console.Clear();
    
    int correctAnswer = 0;

    for (int i = 1; i <= 5; i++)
    {
        int numOne = generateNumber();
        int numTwo = generateNumber();

        Console.WriteLine($"{i}. What is {numOne} + {numTwo}?");
        int? answer = int.Parse(Console.ReadLine()!);
        if (answer == (numOne + numTwo))
        {
            ++correctAnswer;
            Console.WriteLine("Correct!");
        } 
        else
        {
            Console.WriteLine("Incorrect!");    
        }
    }

    Console.WriteLine($"\nYou got {correctAnswer} out of 5 correct.\n");
    Console.WriteLine("Press enter to return to the menu");
    Console.ReadLine();
    results.Add($"Addition Game Result: {correctAnswer}/5");
    Menu(results);
}

static void SubtractionGame(List<string> results)
{
    Console.Clear();
    
    int correctAnswer = 0;

    for (int i = 1; i <= 5; i++)
    {
        int numOne = generateNumber();
        int numTwo = generateNumber();

        Console.WriteLine($"{i}. What is {numOne} - {numTwo}?");
        int? answer = int.Parse(Console.ReadLine()!);
        if (answer == (numOne - numTwo))
        {
            ++correctAnswer;
            Console.WriteLine("Correct!");
        } 
        else
        {
            Console.WriteLine("Incorrect!");    
        }
    }

    Console.WriteLine($"\nYou got {correctAnswer} out of 5 correct.\n");
    Console.WriteLine("Press enter to return to the menu");
    Console.ReadLine();
    results.Add($"Subtraction Game Result: {correctAnswer}/5");
    Menu(results);
}

static void MultiplicationGame(List<string> results)
{
    Console.Clear();
    
    int correctAnswer = 0;

    for (int i = 1; i <= 5; i++)
    {
        int numOne = generateNumber();
        int numTwo = generateNumber();

        Console.WriteLine($"{i}. What is {numOne} * {numTwo}?");
        int? answer = int.Parse(Console.ReadLine()!);
        if (answer == (numOne * numTwo))
        {
            ++correctAnswer;
            Console.WriteLine("Correct!");
        } 
        else
        {
            Console.WriteLine("Incorrect!");    
        }
    }

    Console.WriteLine($"\nYou got {correctAnswer} out of 5 correct.\n");
    Console.WriteLine("Press enter to return to the menu");
    Console.ReadLine();
    results.Add($"Multiplication Game Result: {correctAnswer}/5");
    Menu(results);
}

static void DivisionGame(List<string> results)
{
    Console.Clear();
    
    int correctAnswer = 0;

    for (int i = 1; i <= 5; i++)
    {
        int numOne = 0;
        int numTwo = 1;
        do
        {
            Random rnd = new Random();
            numOne = generateNumber();
            numTwo = generateNumber();
        } while(numOne % numTwo != 0);

        Console.WriteLine($"{i}. What is {numOne} / {numTwo}?");
        int? answer = int.Parse(Console.ReadLine()!);
        if (answer == (numOne / numTwo))
        {
            ++correctAnswer;
            Console.WriteLine("Correct!");
        } 
        else
        {
            Console.WriteLine("Incorrect!");    
        }
    }

    Console.WriteLine($"\nYou got {correctAnswer} out of 5 correct.\n");
    Console.WriteLine("Press enter to return to the menu");
    Console.ReadLine();
    results.Add($"Division Game Result: {correctAnswer}/5");
    Menu(results);
}