using FluentAssertions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FizzBuzz.Tests;

// Given a number n, return a string where
//
// "FizzBuzz" if the number is divisible by 3 and 5
// "Fizz" if the number is divisible by 3
// "Buzz" if the number is divisible by 5
// number (as a string) if none of the conditions are true
public class FizzBuzzTest
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(8)]
    public void GivenANumberNotDivisibleby3or5_ThenReturnNumberAsString(int number)
    {
        string result = FizzBuzzGame.Play(number);
        result.Should().Be(number.ToString());

    }

    [Fact]
    public void GivenANumberIsDIvisibleBy5_ThenReturnBuzz() {
        string result = FizzBuzzGame.Play(5);
        result.Should().Be("Buzz");
    }
}