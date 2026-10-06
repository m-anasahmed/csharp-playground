// ************************************************************
// Unit 06 - Challenge: Create a program with user interaction
Console.WriteLine("========== Unit 06 ==========");
// ************************************************************
// Challenge Source:
// https://microsoftlearning.github.io/mslearn-csharp-programming/Instructions/Exercises/01b-build-user-interaction.html

// Greeting Welcome Message
Console.WriteLine(new string('=', 40));
Console.WriteLine("Welcome to Greeting Page!");

// Ask for the user's name
Console.Write("\nWhat is your name? ");
string name = Console.ReadLine();

// Ask for the user's age
Console.Write("How old are you? ");
string age = Console.ReadLine();

// Display a personalized message that includes both pieces of information
Console.WriteLine($"Hello, {name}! You are {age} years old. \nIt's pleasure to meet you. \nThanks for coming!");

Console.WriteLine(new string('=', 40));


// ************************************************************
// Unit 07 - Module Assessment Test
// Unit 08 - Summary of whole module
// ************************************************************

// From Unit 08:
// What you've accomplished

// In this module, you:

// Displayed output to the console using Console.WriteLine() and Console.Write()
// Accepted user input using Console.ReadLine() and stored it in variables
// Manipulated strings using concatenation, string interpolation, and string methods
// Built programs that interact with users and display personalized messages

// Key concepts to remember
// Console.WriteLine() prints text and adds a line break
// Console.Write() prints text without adding a line break
// Console.ReadLine() pauses your program and waits for user input (always returns a string)
// String interpolation with $"..." makes it easy to combine text and variables
// String methods like .ToUpper(), .ToLower(), and .Replace() let you modify text
// Escape characters like \n and \t control formatting
// Always end statements with a semicolon (;)
// Text must be enclosed in double quotes (")


// End of Code.