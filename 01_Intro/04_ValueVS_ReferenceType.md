# Value VS. Reference types in C# 

All data types can be divided into two categories based on how they are handled in memory 

### Value type and reference type 

1. Value Type: 

Value types are data stored directly, and are stored in the stack, their allocation and  de-allocation are managed automatically by the stack as the program grows and shrinks 

Value types include:

int, float, long, double, char, bool, decimal, 
struct, and enum

All of the above are 'nullable' which is the type followed by a '?' int?, double?, float? meaning those can hold the value type or null

NOTE value types can be stored in the heap if part of a reference type 

Reference type is a type that refers to the memory 
location of the data, not the data itself, it just 
stores where the data is in RAM

Reference data types include string, class, Arrays

This type only copies a reference to the data, not 
the data itself 