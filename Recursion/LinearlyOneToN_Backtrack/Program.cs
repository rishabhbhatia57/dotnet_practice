public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter the vaue of N to print the series from 1 to N: ");
        int n = int.Parse(Console.ReadLine());
        PrintLinearly(n, n);
    }
    public static void PrintLinearly(int i, int n)
    {
        if (i < 1) 
        {
            return;
        }
        PrintLinearly(i-1, n);
        Console.WriteLine(i);
    }
}