// Reverse Array of Strings: Write a method to reverse an array of strings in C#.

string[] names = new string[] { "tilak", "bibek", "binod", "anil"};
Array.Reverse(names);
foreach (string name in names){
    Console.WriteLine(name);
}