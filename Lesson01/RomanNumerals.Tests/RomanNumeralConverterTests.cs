using RomanNumerals;

namespace RomanNumerals.Tests;

public class RomanNumeralConverterTests
{
    // parameterised positive test: this one test runs with several data sets
    [Theory]
    [InlineData("I", 1)]
    [InlineData("III", 3)]
    [InlineData("IV", 4)]
    [InlineData("V", 5)]
    [InlineData("IX", 9)]
    [InlineData("XIV", 14)]
    [InlineData("XL", 40)]
    [InlineData("XLIX", 49)]
    [InlineData("XCIV", 94)]
    [InlineData("CD", 400)]
    [InlineData("CM", 900)]
    [InlineData("MDCCCLXVII", 1867)]
    [InlineData("MMMCMXCIX", 3999)]
    public void ToDecimal_ValidRomanNumeral_ReturnsDecimalValue(string roman, int expected)
    {
        // act
        var result = RomanNumeralConverter.ToDecimal(roman);

        // assert
        Assert.Equal(expected, result);
    }

    // parameterised negative test: invalid input must be rejected
    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("A")]
    [InlineData("XAI")]
    [InlineData("IIII")]
    [InlineData("VV")]
    [InlineData("IL")]
    [InlineData("IC")]
    [InlineData("VX")]
    [InlineData("MMMM")]
    public void ToDecimal_InvalidRomanNumeral_ThrowsArgumentException(string roman)
    {
        // Assert - no Act variable is needed because the method must throw
        Assert.Throws<ArgumentException>(() => RomanNumeralConverter.ToDecimal(roman));
    }

    [Fact]
    public void ToDecimal_Null_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => RomanNumeralConverter.ToDecimal(null!));
    }
}
