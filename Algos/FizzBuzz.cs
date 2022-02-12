using System.Text;

namespace Algos
{
    public class FizzBuzz
    {
        public static string ForWithStringBuilder(int n)
        {
            var sb = new StringBuilder();
            if (n % 5 == 0)
                sb.Append("Fizz");
            if (n % 3 == 0)
                sb.Append("Buzz");
            else
                sb.Append(n);
            return sb.ToString();
        }

        public static string ForWithIfElseReturns(int n)
        {
            if (n % 5 == 0 && n % 3 == 0)
                return "FizzBuzz";
            if (n % 5 == 0)
                return "Fizz";
            if (n % 3 == 0)
                return "Buzz";
            return n.ToString();
        }
    }
}
