// Data Types

// Strings are reference types, meaning they store references to their data, 
// allowing for more flexible manipulation and resizing of the string data.
string myName = "Luke";

// ints (integers) are value types, meaning they store data directly. 
// They are used for whole numbers and can be negative or positive.
int myAge = 22;

// Example of an integer that can represent negative values, 
// such as a golf score, where negative values are common.
int golfRoundScore = -4;

// For values that are guaranteed to never be negative, use uint (unsigned integer). 
// This data type can only store positive numbers, allowing for a larger positive range.
uint neverNegativeValue = 2555555;

// short data type can hold values from -32768 to 32767. 
// It's useful for saving memory when you know the value will fit within this range.
short myLinkedInFriends = 32550;

// The long data type is used for very large integers. 
// It's particularly useful for values like phone numbers or other large counts.
long phoneNumber = 4445551234;

// float data types are used to store decimal numbers with single precision. 
// They must be postfixed with the F flag to differentiate them from double literals.
// Suitable for scenarios where precision is not critical, and memory savings are needed.
float floatPi = 3.14121F;

// double data types store decimal numbers with double precision. 
// They are the default type for decimals and are used when higher precision is needed.
double pi = 3.14;

// byte type represents an 8-bit unsigned integer, meaning it can store values from 0 to 255.
// Useful for small numbers where memory efficiency is important.
byte age = 15;

// sbyte type represents an 8-bit signed integer, meaning it can store values from -128 to 127.
// Useful for small negative values in memory-efficient scenarios.
sbyte lbsWeightLost = -50;

// Displaying the weight lost using the sbyte type.
Console.WriteLine($"Total weight lost: {lbsWeightLost} lbs");
Console.ReadKey();
