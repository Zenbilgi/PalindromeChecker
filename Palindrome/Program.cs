using System.Text;
using System.Text.RegularExpressions;


Console.WriteLine("Palindrome Checker");
Console.WriteLine("------------------");
Console.Write("Enter a string: ");
string input = Console.ReadLine();

// Remove punctuation marks and spaces
string cleanedInput = StringOperation.RemovePunctuationAndSpaces(input);

// Reverse the cleaned string
string reversedInput = StringOperation.ReverseString(cleanedInput);

// Check if the cleaned string is equal to its reverse
bool isPalindrome = StringOperation.IsStringPalindrome(cleanedInput, reversedInput);

// Output the result
Console.WriteLine();
Console.WriteLine($"Original string: {input}");
Console.WriteLine($"Cleaned string: {cleanedInput}");
Console.WriteLine($"Reversed string: {reversedInput}");
Console.WriteLine($"Is Palindrome: {isPalindrome}");

Console.ReadKey();
