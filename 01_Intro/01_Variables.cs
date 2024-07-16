// VARIABLES 

// All variables in C# must be typed, integers,
// strings, booleans etc.. 

// Whole Numbers are typed with int  
int myNumber = 5;
// Decimals or floating point number are floats
float myNumber2 = 5.1315F; // Use the 'F' suffix for float literals
// Boolean true or false values 
bool iKnowCSharp = false;
// string values are annotated with string:
string myName = "Luke";
// single characters are defined with char 
char myFavoriteLetter = 'G'
// Using string interpolation for formatting the output
Console.WriteLine($"iKnowCSharp: {iKnowCSharp}, myNumber2: {myNumber2}, myNumber: {myNumber}, myName: {myName}");
Console.ReadLine();

// Note that using proper data types help conserve 
// memory 

// Using a string when you know you only need a single 
// letter will work, but is a poor choice since 
// strings use more memory than char data type 

// think of it like using a gigantic coffee cup for just a 
// small shot of espresso, it's overkill, a small 
// cup is a better solution