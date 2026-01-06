public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string to find first non-repeating character: ");
        string input = Console.ReadLine();
        char[] chars = input.ToCharArray();

        char result = NonRepeatingChar(chars);
        Console.WriteLine(result);
    }
    public static char NonRepeatingChar(char[] chars)
    {
        Dictionary<char, int> charlist = new Dictionary<char, int>();

        for(int i=0; i<chars.Length; i++)
        {
            if (charlist.ContainsKey(chars[i]))
            {
                charlist[chars[i]] += 1;
            }
            else
            {
                charlist[chars[i]] = 1;
            }
        }
        foreach (var pair in charlist)
        {
            Console.WriteLine("key {0} and value {1}",pair.Key, pair.Value);
        }
        for (int j = 0; j < chars.Length; j++)
        {
            if (charlist[chars[j]] == 1)
            {
                return chars[j];
            }
        }
        return '0';
    }
}