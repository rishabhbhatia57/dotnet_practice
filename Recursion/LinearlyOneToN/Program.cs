public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter last number to print series from 1 to n: ");
        int n = int.Parse(Console.ReadLine());
        PrintLinearly(n);
    }
    static int count = 1;
    public static void PrintLinearly(int n)
    {
        if (count > n)
        {
            return;
        }
        Console.WriteLine(count);
        count++;
        PrintLinearly(n);
    }
}