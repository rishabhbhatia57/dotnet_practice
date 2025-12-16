public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number to print the sum of n to 1 numbers: ");
        int n = int.Parse(Console.ReadLine());
        Sum_Paramterized(n, 0);
        Console.WriteLine(Sum_Funtional(n));
    }

    //Sum of first n number using Recursion - Paramterized
    public static void Sum_Paramterized(int i, int sum)
    {
        if (i < 1)
        {
            Console.WriteLine("Sum : "+sum);
            return;
        }
        Sum_Paramterized(i-1, sum + i);
    }

    public static int Sum_Funtional(int n)
    {
        int sum = 0;
        if (n == 0)
        {
            return 0;
        }
        else
        {
            sum = n + Sum_Funtional(n - 1);
        }
        return sum;
    }

}