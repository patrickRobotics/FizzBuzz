
namespace FizzBuzz
{
    public static class FizzBuzzGame
    {
        public static string Play(int num)
        {
            return num switch
            {
                _ when num.IsDibisibleBy(15) => "FizzBuzz",
                _ when num.IsDibisibleBy(3) => "Fizz",
                _ when num.IsDibisibleBy(5) => "Buzz",
                _ => num.ToString(),
            };
        }

        private static bool IsDibisibleBy(this int i, int divisibleBy)
        => i % divisibleBy == 0;
    }
}
