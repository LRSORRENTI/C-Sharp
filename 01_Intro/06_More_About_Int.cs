// More on the INT datatype and Parsing

// More on the INT datatype and Parsing

Console.WriteLine("Enter a whole number, not text like ten for 10, just enter the number 10");

// Initialize number variables;
int myNumber = 0;
int mySecondNumber = 0;

// Grab the first user input number
string userInput = Console.ReadLine()!;

// Ask for second user input number 
Console.WriteLine("Please enter a second number to sum with the first");

// Grab second user input number 
string secondInput = Console.ReadLine()!;

// Turn the string input for both into actual int data type 
// using int.Parse for each 
myNumber = int.Parse(userInput);
mySecondNumber = int.Parse(secondInput);

// Sum the two inputs and return them to the user 
System.Console.WriteLine("The sum is " + (myNumber + mySecondNumber));

Console.ReadKey();