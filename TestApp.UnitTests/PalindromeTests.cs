using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new List<string> { "level" };
        bool expected = true;
        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> input = new();

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> input = new() { "asdsa"};

        //Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(result, Is.True);

    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> input = new() { "Hello" };

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new() { "LeVeL"};

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(result, Is.True);
    }
}
