public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the elements of Array: ");
        int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int[] SortedArray = SelectionSort(arr);
        PrintArray(SortedArray);
    }
    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    public static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(",", arr));
    }
    public static int[] SelectionSort(int[] arr)
    {
        int minIndex = 0;
        for(int i=0; i < arr.Length; i++)
        {
            minIndex = i;
            for(int j=i+1; j< arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                Swap(ref arr[minIndex], ref arr[i]);
            }
        }
        return arr;
    }
}
