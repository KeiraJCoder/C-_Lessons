
# C# Learning Project - String Manipulation

This project is a simple C# console application demonstrating various string operations. It includes string trimming, interpolation, replacing characters, checking string contents, and more. Below, you'll find explanations for the key string operations used in the code.

## How to Run This Project

1. **Install the .NET SDK**:
   - You can download it from [here](https://dotnet.microsoft.com/download).

2. **Add .NET to Your System Path (if needed)**:
   - If you face any issues with the `dotnet` command not being recognized, follow the steps to add `.NET` to your system’s environment variables:
     - Open **Environment Variables**:
       - Search for "Environment Variables" in the Start Menu.
       - Under **System Variables**, click on the `Path` variable, and click **Edit**.
       - Click **New**, and add the path where the .NET SDK is installed, typically `C:\Program Files\dotnet\`.
       - Save the changes and restart your terminal.

3. **Run the Project**:
   - Navigate to the project directory in your terminal:
     ```bash
     cd path\to\your\project
     ```
   - Use the following command to create a new C# console application:
     ```bash
     dotnet new console
     ```
   - Copy the provided code into the `Program.cs` file.
   - To run the project, use the following command:
     ```bash
     dotnet run
     ```

## C# Code Sample

```csharp
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Keira!");

// console.log (print) 

string firstFriend =  "            Jade          ";
firstFriend = firstFriend.TrimStart();
firstFriend = firstFriend.TrimEnd();
firstFriend = firstFriend.Trim();
// removes white space, either at start, end or entire

string secondFriend = "Lorelei";
// define a string using the keyword data type, variable name and data
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
// concatenate (interpolation) using $ and {}

string supercali = "Supercalifragilisticexpealedocious";
supercali = supercali.Replace("p", "d");
// replace first item with second
// can use with strings
Console.WriteLine(supercali);

string friends2 = $"My friends are {firstFriend} and {secondFriend}";

Console.WriteLine(friends2);
Console.WriteLine(friends2.Replace("Jade", "Hollie"));
// NOT actually updating the original string
// returns a NEW string with the information
// DOES NOT UPDATE

// strings are IMMUTABLE, CANNOT be changed or fixed, CONST?
friends2 = friends2.Replace("Jade", "Hollie");
// ONLY WAY to update is to redefine string with new value

Console.WriteLine(friends2.Contains("Hollie"));
// can search within strings for data

Console.WriteLine(friends2.ToUpper());
Console.WriteLine(friends2.ToLower());
// to upper and to lower, does what it says on the tin

Console.WriteLine(friends2.Length);
// is not function, does not need ()

Console.WriteLine(friends2.StartsWith("My"));
Console.WriteLine(friends2.EndsWith("Jade"));
// checks string for what it starts with or ends with, True/False

Console.WriteLine(friends2);
```

## Key String Operations

Here’s a breakdown of the key string operations used in the project:

- **Trim Whitespace**: 
  - `TrimStart()`, `TrimEnd()`, and `Trim()` methods are used to remove leading, trailing, or both leading and trailing whitespace.
  
- **String Interpolation**:
  - Use the `$` symbol to interpolate variables into strings, e.g., `$"My friends are {firstFriend} and {secondFriend}"`.

- **Replace Characters**:
  - Use `Replace()` to substitute one character or substring for another. Example: `supercali.Replace("p", "d")`.

- **String Immutability**:
  - Strings in C# are immutable, meaning you cannot modify a string directly. Instead, you need to assign a new value, e.g., `friends2 = friends2.Replace("Jade", "Hollie");`.

- **Contains, ToUpper, ToLower**:
  - Use `Contains()` to check if a string contains a specific substring.
  - Use `ToUpper()` and `ToLower()` to change the string to uppercase or lowercase, respectively.

- **String Length**:
  - Use `.Length` to find out how many characters are in the string.

- **StartsWith and EndsWith**:
  - Use `StartsWith()` and `EndsWith()` to check if a string begins or ends with a specific value, returning `true` or `false`.

## Example Output

```plaintext
Hello, Keira!
My friends are Jade and Lorelei
Suderdalidradilistidexdealedocious
My friends are Jade and Lorelei
My friends are Hollie and Lorelei
True
MY FRIENDS ARE HOLLIE AND LORELEI
my friends are hollie and lorelei
33
True
False
My friends are Hollie and Lorelei
```

## Additional Resources

For more information, see the [Microsoft C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/).

Happy Coding!
