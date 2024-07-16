# Coding Standards 

**Coding standards are sets of practices and guidelines when developing software applications**

Note that different companies may have stricter, or looser 
standards for their software 

Standards:

1. Always use apt, descriptive variable names. If we want to store the age of a user a good name would be userAge

2. Always be descriptive for function names, what the essence of the function is should be incorporated into it's name, like
``` void CheckInternetConnection() {
    // checking network code inside 
}
```
An example of bad naming is 
```
void MyFunction() {
    /* checking network code inside 
        multi line comment
    */
}
```
3. Always leave comments explaining what's happening in your code, this drastically improves readability, ease of collaboration between team members, and makes debugging easier 

4. You can integrate XML comments as well so that if someone hovers over a function, it displays the comment:

```
static void Main(string[] args) // Main Method
{
    CoolMethod();
}
/// <summary>
/// This is a cool method
/// </summary>

static void CoolMethod() {
    // cool code 
}
```

5. Consistency is key, adhere to a consistent naming convention throughout your codebase, don't switch between camelCase, snake_case or other styles 

6. Prioritize readability, and understandibility as a cornerstone, this helps the entire team working in a shared codebase!

## Naming conventions

1. Classes & Methods - For classes & methods in C# you should use Pascal case which is MyClassHere, BusinessClass, AnimalClass etc.. 

2. Variables - Typically you'll want to adhere to camelCase for variables in C#