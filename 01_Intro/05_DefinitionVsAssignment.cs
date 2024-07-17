// Variable assignment vs definition 

// In C# often times you'll need to define a variable, 
// and then assign a value to it later, 
// maybe after a user input read:

// Declare an integer variable named 'i'
int i;

// Prompt the user to enter an integer
Console.Write("Enter an integer: ");

// Read the user input from the console, convert it to an integer, and assign it to 'i'
i = Convert.ToInt32(Console.ReadLine());

// Display the value entered by the user
// {0} is a placeholder for the first argument that follows the format string.
// {1}, {2}, etc., would be placeholders for the second, third, and subsequent arguments, respectively.
Console.WriteLine("You entered {0}", i);

// Wait for the user to press Enter before proceeding
Console.ReadLine();

// Reassign the value of 'i' to 66
i = 66;

// Display the new value of 'i'
Console.WriteLine("Reassigned var i to: {0} ", i);

// Wait for the user to press Enter before ending the program
Console.ReadLine();
