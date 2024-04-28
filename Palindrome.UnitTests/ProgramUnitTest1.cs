namespace Palindrome.UnitTests;

[TestFixture]
public class StringOperationTests
{
    [Test]
    public void RemovePunctuationAndSpaces_RemovesPunctuationAndSpacesCorrectly()
    {
        // Arrange
        string input = "Ey edip Adana'da pide ye!";
        string expected = "EyedipAdanadapideye";

        // Act
        string result = StringOperation.RemovePunctuationAndSpaces(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void ReverseString_ReversesStringCorrectly()
    {
        // Arrange
        string input = "hello";
        string expected = "olleh";

        // Act
        string result = StringOperation.ReverseString(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void IsPalindrome_ReturnsTrueForPalindrome()
    {
        // Arrange
        string input = "Kazak";
        string expected = "kazak";


        // Act
        bool result = StringOperation.IsStringPalindrome(input, expected);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void IsPalindrome_ReturnsFalseForNonPalindrome()
    {
        // Arrange
        string input = "hello";
        string expected = "olleh";

        // Act
        bool result = StringOperation.IsStringPalindrome(input, expected);

        // Assert
        Assert.IsFalse(result);
    }
}

