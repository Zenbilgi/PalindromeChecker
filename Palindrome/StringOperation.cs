using System;
using System.Text;
using System.Text.RegularExpressions;

public class StringOperation
{

    public static string RemovePunctuationAndSpaces(string input)
    {
        // Remove punctuation marks using regular expression
        string withoutPunctuation = Regex.Replace(input, "[^a-zA-Z0-9]", "");

        // Remove spaces
        string withoutSpaces = withoutPunctuation.Replace(" ", "");

        return withoutSpaces;
    }

    public static string ReverseString(string input)
    {
        // return new string(input.Reverse().ToArray());

        int len = input.Length;

        StringBuilder sb = new StringBuilder();

        for (int i = len - 1; i >= 0; i--)
        {
            sb.Append(input[i]);
        }

        return sb.ToString();
    }

}

