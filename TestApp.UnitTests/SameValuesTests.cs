using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SameValuesTests
{
    [Test]
    public void Test_FindSameValues_EmptyFirstList_ReturnsEmptyList()
    {
        // Arrange
        List<int> list1 = new List<int>();
        List<int> list2 = new () {1, 2, 3 };

        // Act
        List<int> result = SameValues.FindSameValues(list1, list2);

        // Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_FindSameValues_EmptySecondList_ReturnsEmptyList()
    {
        // Arrange
        List<int> list1 = new List<int>() { 1, 2, 3 };
        List<int> list2 = new();

        // Act
        List<int> result = SameValues.FindSameValues(list1, list2);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_NoSameValuesInBothLists_ReturnsEmptyList()
    {
        // Arrange
        List<int> list1 = new List<int>() { 1, 2, 3 };
        List<int> list2 = new() { 4, 5, 6 };

        // Act
        List<int> result = SameValues.FindSameValues(list1, list2);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_BothListWithSameValues_ReturnsListWithSameValues()
    {
        // Arrange
        List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
        List<int> list2 = new() { 1, 2, 3, 4, 5, 6 };

        // Act
        List<int> result = SameValues.FindSameValues(list1, list2);

        // Assert
        Assert.That(result, Is.EqualTo(list1));
    }
}
