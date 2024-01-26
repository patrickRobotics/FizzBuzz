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

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(25)]
    public void GivenANumberIsDIvisibleBy5_ThenReturnBuzz(int number) {
        string result = FizzBuzzGame.Play(number);
        result.Should().Be("Buzz");
    }

    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    public void GivenANumberIsDIvisibleBy3_ThenReturnFizz(int number)
    {
        string result = FizzBuzzGame.Play(number);
        result.Should().Be("Fizz");
    }


    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(60)]
    public void GivenANumberIsDIvisibleBy3And5_ThenReturnFizzBuzz(int number)
    {
        string result = FizzBuzzGame.Play(number);
        result.Should().Be("FizzBuzz");
    }
}