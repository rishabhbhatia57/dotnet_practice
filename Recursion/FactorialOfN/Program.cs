public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number to pint factorial of n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Factorial of {0} is {1}",n,Factorial(n));
    }

    public static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        if (n == 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }
}