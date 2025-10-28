using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveLessThanOrEqualToTests
{
    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_EmptyListParameter_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new List<int>() { };
        int treshhold = 6;

        // Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, treshhold);

        // Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanOrEqualToThresholdElements_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new List<int>() { 1, 2, 3, 4 };
        int treshhold = 6;
        List<int> expected = new List<int>();

        // Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, treshhold);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithOnlyGreaterThanThresholdElements_ReturnsSameList()
    {
        // Arrange
        List<int> input = new List<int>() { 8, 2, 3, 4 };
        int treshhold = 1;
        List<int> expected = new List<int>() { 8, 2, 3, 4 };

        // Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, treshhold);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyGreaterThanThreshold()
    {
        // Arrange
        List<int> input = new List<int>() { 8, 2, 3, 4, 19, 28};
        int treshhold = 4;
        List<int> expected = new List<int>() { 8, 19, 28 };

        // Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, treshhold);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
