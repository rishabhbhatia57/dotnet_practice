public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of N to print the series from N to 1: ");
        int n = int.Parse(Console.ReadLine());
        PrintLinearly(n);
    }
    public static void PrintLinearly(int n)
    {
        int count = n;
        if (count < 1)
        {
            return;
        }
        Console.WriteLine(count);
        count--;
        PrintLinearly(count);
    }
}