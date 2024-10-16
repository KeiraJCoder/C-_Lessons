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


