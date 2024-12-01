using Advent2024.Day_1;

namespace Advent2024Tests.Day1;

public class DayOneTests
{
    #region MyRegion

    private readonly DayOne _sut = new();

    #endregion
    
    [Fact]
    public void RunPartOne_ValidSampleInput_Should_ReturnCorrectValue()
    {
        // Arrange 
        var expectedListOne = new List<int> {3,4,2,1,3,3};
        var expectedListTwo = new List<int> {4,3,5,3,9,3 };
        
        // Act 
        var result = _sut.RunPartOne(expectedListOne, expectedListTwo);
        
        // Assert
        Assert.Equal(11, result);
    }

    [Fact]
    public void RunPartTwo_ValidSampleInput_Should_ReturnCorrectValue()
    {
        // Arrange 
        var expectedListOne = new List<int> {3,4,2,1,3,3};
        var expectedListTwo = new List<int> {4,3,5,3,9,3 };
        
        // Act 
        var result = _sut.RunPartTwo(expectedListOne, expectedListTwo);
        
        // Assert
        Assert.Equal(31, result);
    }
}