public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter nuber to find Fibonacci of number: ");
        int n = int.Parse(Console.ReadLine());
        int result = Fibonacci(n);
        Console.WriteLine(result);
    }
    public static int Fibonacci(int n)
    {
        if(n <= 1)
        {
            return n;
        }
        return Fibonacci(n-1) + Fibonacci(n - 2);
    }

}