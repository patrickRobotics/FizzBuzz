namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public static string Play(int i)
        {
            if (i == 5)
            {
                return "Buzz";
            }
            return i.ToString();
        }

    }
}
