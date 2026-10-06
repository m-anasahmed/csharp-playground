// ************************************************************
// Lectures 02 (Practical Start from this Lecture)
// ************************************************************

Console.WriteLine("Hello, World!");

// In C#, text must always be enclosed in double quotes ("). 
// Single quotes (') won't work for text. Make sure you use the straight quotes (") and not curly quotes.

// Notice the semicolon (;) at the end of the line. 
// In C#, every instruction must end with a semicolon. It tells the computer you've finished entering the command.

//You can pass multiple values to Console.WriteLine() by separating them with commas. C# automatically inserts a space between each item.
Console.WriteLine("Hello", "World!", "By Anas");   // Not working in VS Code.
Console.WriteLine("Hello, World! by Anas");

/*
Escape sequence	    What it does	            Example	                                Output
\n	                Moves text to a new line	Console.WriteLine("Line 1\nLine 2");	Line 1
                                                                                        Line 2
\t	                Adds a tab space	        Console.WriteLine("Name:\tAlex");	    Name: Alex
\\	                Prints a literal backslash	Console.WriteLine("Path: C:\\Users");	Path: C:\Users
\"	                Prints a double quote	    Console.WriteLine("She said, \"Hi!\"");	She said, "Hi!"
*/

// Make sure to use the backslash (\) and not the forward slash (/).

// There's another method called Console.Write() that works similarly to Console.WriteLine(), but with one important difference:
// Console.WriteLine() adds a line break at the end, moving the next output to a new line
// Console.Write() prints to the current line without adding a line break

Console.Write("Hello");
Console.Write(" ");
Console.Write("world!");

// or we use Console.WriteLine("");

Console.WriteLine("\nHello");
Console.WriteLine(" ");
Console.WriteLine("world!");

