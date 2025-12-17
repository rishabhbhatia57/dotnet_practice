public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string to check for palindrome: ");
        Char[] s = Console.ReadLine().ToCharArray();
        Console.WriteLine(CheckPalindrome(s, 0, s.Length));
    }
    public static bool CheckPalindrome(Char[] s, int i, int size)
    {
        if (i >= size / 2)
        {
            return true;
        }
        if (s[i] != s[size - i - 1])
        {
            return false;
        }
        return CheckPalindrome(s, i + 1, size);
    }
}