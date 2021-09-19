using Console;
using Xunit;

namespace web_api_tests;

public class Record1Tests
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var expected = 42;
        var underTest = new Record1(expected, 12);

        // Act
        // underTest.Age = expected;

        // Assert
        Assert.Equal(expected, underTest.Age);
    }

    [Fact]
    public void ThisIsNotATest()
    {
        var underTest = new Record1(12, 12);
        var representation = underTest.ToString();
        System.Console.WriteLine(underTest);
        System.Diagnostics.Debug.WriteLine(underTest);
    }

    [Fact]
    public void EqualityTest()
    {
        // Arrange
        var expected = 42;
        var underTest1 = new Record1(expected, 12);
        var underTest2 = new Record1(expected, 12);

        // Act

        // Assert
        Assert.Equal(underTest1, underTest2);
    }
}