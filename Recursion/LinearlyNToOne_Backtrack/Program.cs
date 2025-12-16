public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of n to Print the series from N to 1: ");
        int n = int.Parse(Console.ReadLine());
        PrintLinearly(1, n);

    }
    public static void PrintLinearly(int i, int n)
    {
        if (i > n) 
        {
            return;
        }
        PrintLinearly(i+1, n);
        Console.WriteLine(i);
    }
}

