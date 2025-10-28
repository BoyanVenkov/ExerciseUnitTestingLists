using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveGreaterThanTests
{
    [Test]
    public void Test_RemoveElementsGreaterThan_EmptyListParameter_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new List<int>();
        int treshhold = 7;

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, treshhold);

        // Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithGreaterThanThresholdElements_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new List<int>() { 7, 8, 9, 10, 11};
        int treshhold = 6;

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, treshhold);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanOrEqualToThresholdElements_ReturnsSameList()
    {
        // Arrange
        List<int> input = new List<int>() { 7, 8, 9, 10, 11 };
        int treshhold = 11;

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, treshhold);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyLessThanOrEqualToThreshold()
    {
        // Arrange
        List<int> input = new List<int>() { 7, 8, 9, 10, 11, 35 };
        int treshhold = 10;
        List<int> expected = new List<int>() { 7, 8, 9, 10 };

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, treshhold);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
