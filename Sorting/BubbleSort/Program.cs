public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the elements of Array: ");
        int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int[] sortedArray = BubbleSort(arr);
        PrintArray(sortedArray);
    }
    public static int[] BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    Swap(ref arr[j], ref arr[j + 1]);
                }
            }
        }
        return arr;
    }
    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    public static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }
}