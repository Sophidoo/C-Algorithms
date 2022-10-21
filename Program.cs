namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Palindrome palindrome = new Palindrome();
            Console.WriteLine(palindrome.PalindromeSolution());
            palindrome.smallestNumber();
            palindrome.Duplicate();
            palindrome.reoccurChar();
        }
    }
}