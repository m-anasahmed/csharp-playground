// ************************************************************
// Unit 04 - Manipulate Strings
Console.WriteLine("========== Unit 04 ==========\n");
// ************************************************************

// Text is one of the most common types of data in programming. 
// In C#, text is represented as a string—a sequence of characters enclosed in double quotes. 
// C# provides many built-in ways to manipulate and format strings.

// Concatenation (joining strings together)
// You can join two or more strings together into a single string using the + operator.

// Provided example
string first = "Hello";
string last = "World";
string message = first + ", " + last + "!";
Console.WriteLine(message);

// New - Second example
string firstName = "John";
string lastName = "Doe";
string fullName = firstName + " " + lastName;
string fullMessage = "Hello, " + fullName + "!";
Console.WriteLine(fullMessage);


// A better way: String interpolation
// A cleaner, modern way to combine strings and variables is with string interpolation. 
// To create this kind of string, place a dollar sign ($) directly before your opening quote, 
// and place any variable names inside curly braces {}.

string firstName1 = "Charles";
string lastName2 = "John";
Console.WriteLine($"Hello, {firstName1} {lastName2}! It's nice to meet you.");


// A cleaner way to combine input and output with user input.
Console.Write("Tell us your Full name: ");
string fullName1 = Console.ReadLine();
Console.WriteLine($"Hello, {fullName1}! Nice to meet you.");


// If you forget the $ prefix, C# won't look inside the braces—it will literally print {name} on the screen.
Console.WriteLine("Hello, {name}");


// Common string methods
// C# strings have many built-in methods for common operations. 
// To use a method, type the variable name, a dot, and the method name followed by parentheses:

/* 
Method	                What it does	                Example	                    Result
.ToUpper()	            Converts text to uppercase	    "hello".ToUpper()	        "HELLO"
.ToLower()	            Converts text to lowercase	    "HELLO".ToLower()	        "hello"
.Replace(old, new)	    Swaps out specific characters	"cat".Replace("c", "b")	    "bat"
.Length	Returns the number of characters	            "Alex".Length	            4
*/

// Runnable example
Console.WriteLine("\nCommon String Method Example:");
Console.WriteLine("hello".ToUpper());
Console.WriteLine("HELLO".ToLower());
Console.WriteLine("hello".Replace("h", "b"));
Console.WriteLine("hello".Length + "\n");


// Practical example:
Console.Write("Tell us your name: ");
string theirName = Console.ReadLine();
string fullGreetings = $"Welcome, {theirName.ToUpper()}! It's pleasure to meet you.";
Console.WriteLine(fullGreetings);

// Notice how .ToUpper() converted the user's input to uppercase, and string interpolation made it easy to combine everything together.


// End of Code