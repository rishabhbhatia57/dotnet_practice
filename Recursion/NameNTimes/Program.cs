//Print name n times using recursion
//Time Complexity = BigO(N)
//Space Complexity = BigO(N)
public class Program
{
    public static void Main(String[] args)
    {
        try
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter number how many times you want to print: ");
            int n = int.Parse(Console.ReadLine());
            PrintName(name, n);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
    static int count = 1;
    public static void PrintName(String name, int n)
    {
        if (count > n)
        {
            return;
        }
        Console.WriteLine(name);
        count++;
        PrintName(name, n);
    }
}