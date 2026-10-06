// ************************************************************
// Unit 05 - Exercise: Create a personalized greeting
Console.WriteLine(" ========== Unit 05 ==========\n");
// ************************************************************
// https://microsoftlearning.github.io/mslearn-csharp-programming/Instructions/Exercises/01a-create-a-greeting.html
// Format of the exercise

// Provided Answer:
// Display a welcome message
Console.WriteLine("Welcome to the greeting program!");
// Ask for the user's name
Console.Write("What is your name? ");
string name = Console.ReadLine();
// Display a personalized greeting
Console.WriteLine($"Hello, {name}! It's great to meet you.");


// My Practice Answer:
// Display a welcome message
Console.WriteLine("\nWelcome to the Car registration page");
Console.WriteLine("We are going to ask some details from you to register your car.");

// Ask for the user's name
Console.Write("\nPlease, Enter full name to proceed with the application: ");
string fullName = Console.ReadLine();

// Display a personalized greeting
Console.WriteLine($"\nHello! {fullName}, Thanks for the reply and now we are going to ask some details to move on.");

// Ask for the details
Console.Write("\nPlease, Enter your car name: ");
string carName = Console.ReadLine();
Console.Write("Enter car old registration year: ");
string carYear = Console.ReadLine();
Console.Write("Enter car color year: ");
string carColor = Console.ReadLine();

// Print Car Details with confirmation message:
Console.WriteLine("\nDetails of the Car:");
Console.WriteLine($"Car Name: {carName}");
Console.WriteLine($"Car Color: {carColor}");
Console.WriteLine($"Car year: {carYear}");

Console.WriteLine($"\nThanks for the registration {fullName}. Your car has been registered.");


// Code by AI - Chatgpt:

// Example - 01:
string name001 = "joHnnnnn dEEEEoooo";
string upperName = name001.ToUpper();
string lowerName = name001.ToLower();

Console.WriteLine("\nModifying a variable: \nUpper Case:" + upperName);
Console.WriteLine("Lower Case:" + lowerName);


// Example - 02:
Console.Write("\nModifying a variable with user input, Enter your name: ");
string name002 = Console.ReadLine();

Console.WriteLine("Uppercase: " + name002.ToUpper());
Console.WriteLine("Lowercase: " + name002.ToLower());

// Example - 03:
// if can also modify the original variable

string orginialName = "joHnnnnn dEEEEoooo";
orginialName = orginialName.ToUpper();

Console.WriteLine("\nModifying the Original Variable: " + orginialName);

// End of Code