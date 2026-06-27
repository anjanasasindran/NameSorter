using NameSorter.Models;
using NameSorter.Services;

namespace NameSorter.Tests;

public class NameSorterTests
{
    [Fact]
    public void Sort_Should_Order_By_LastName_Then_GivenNames()
    {
        // Arrange
        var input = new List<PersonName>
        {
            new PersonName(new List<string>{"Janet"}, "Parsons"),
            new PersonName(new List<string>{"Adonis","Julius"}, "Archer"),
            new PersonName(new List<string>{"Beau"}, "Bentley")
        };

        var sorter = new NameSorters();

        // Act
        var result = sorter.Sort(input);

        // Assert
        Assert.Equal("Archer", result[0].LastName);
        Assert.Equal("Bentley", result[1].LastName);
        Assert.Equal("Parsons", result[2].LastName);
    }

    [Fact]
public void Sort_Should_Order_By_GivenNames_When_LastNames_Are_Same()
{
    var input = new List<PersonName>
    {
        new PersonName(new List<string>{"Zara"}, "Smith"),
        new PersonName(new List<string>{"Adam"}, "Smith")
    };

    var sorter = new NameSorters();

    var result = sorter.Sort(input);

    Assert.Equal("Adam", result[0].GivenNames[0]);
    Assert.Equal("Zara", result[1].GivenNames[0]);
}
[Fact]
public void Sort_Should_Handle_Multiple_GivenNames()
{
    var input = new List<PersonName>
    {
        new PersonName(new List<string>{"John","Zed"}, "Brown"),
        new PersonName(new List<string>{"John","Adam"}, "Brown")
    };

    var sorter = new NameSorters();

    var result = sorter.Sort(input);

    Assert.Equal("Adam", result[0].GivenNames[1]);
}
[Fact]
public void Sort_Should_Return_Empty_List_When_Input_Is_Empty()
{
    var sorter = new NameSorters();

    var result = sorter.Sort(new List<PersonName>());

    Assert.Empty(result);
}
}