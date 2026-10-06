// ************************************************************
// Lectures 03 - Accept User Input
Console.WriteLine("Lecture 03");
// ************************************************************

// Provided Example:
// string favoriteColor = Console.ReadLine();
// Console.WriteLine("Oh, I love " + favoriteColor + " too!");

// string favoriteCar = Console.ReadLine();
// Console.WriteLine("Ohh! " + favoriteCar + " is my Favourite Car as well.");

// More Readable way:
Console.Write("What is your favorite drink? ");
string favoriteDrink = Console.ReadLine();
Console.WriteLine("Oh, I love " + favoriteDrink + " too!");

// Console.ReadLine() always returns a string
// An essential rule to remember is that Console.ReadLine() always returns text (a string), even if the user types a number.

// For example: This code will cause an error.
/* 
Console.Write("What is your favorite drink? ");
int  favoriteDrink = Console.ReadLine();
Console.WriteLine("Oh, I love " + favoriteDrink + " too!"); 
*/

// string age = Console.ReadLine();
// Console.WriteLine(age + 1); // This causes an error! or simply print it as 251 if you input 25.