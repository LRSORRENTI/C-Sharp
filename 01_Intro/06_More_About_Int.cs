// More on the INT datatype and Parsing

Console.WriteLine("Enter a whole number, not text like ten for 10, just enter the number 10");

int myNumber = 0;

string userInput = Console.ReadLine()!;

myNumber = int.Parse(userInput);

System.Console.WriteLine("My number is " + myNumber);

Console.ReadKey();