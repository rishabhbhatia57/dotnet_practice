using System.Numerics;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter the size of the Array: ");
        int size = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the elements of Array: ");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        ReverseArray(arr, 0, size);
        Console.WriteLine(string.Join(" ", arr));
    }

    public static void ReverseArray(int[] arr, int i, int size)
    {
        if (i >= size/2)
        {
            return;
        }
        Swap(ref arr[i], ref arr[size-i-1]);
        ReverseArray(arr, i+1, size);
    }
    static void Swap(ref int a, ref int b)
    {
        (a, b) = (b, a);
    }

}