
namespace FizzBuzz
{
    public static class FizzBuzzGame
    {
        public static string Play(int num)
        {
            if (num.IsDibisibleBy(3) && num.IsDibisibleBy(5))
            {
                return "FizzBuzz";
            }
            if (num.IsDibisibleBy(3))
            {
                return "Fizz";
            }
            if (num.IsDibisibleBy(5))
            {
                return "Buzz";
            }
            return num.ToString();
        }

        private static bool IsDibisibleBy(this int i, int divisibleBy)
        => i % divisibleBy == 0;
    }
}
