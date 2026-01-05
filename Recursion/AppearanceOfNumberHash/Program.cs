public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of array: ");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the elements of array: ");
        int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        Dictionary<int, int> Appeaeances = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (Appeaeances.ContainsKey(arr[i]))
            {
                Appeaeances[arr[i]] += 1;
            }
            else
            {
                Appeaeances.Add(arr[i], 1);
            }
        }

        foreach (var pair in Appeaeances)
        {
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }

        Console.WriteLine("How many numbers to be checked for appearances: ");
        int q = int.Parse(Console.ReadLine());

        while (q > 0)
        {
            Console.WriteLine("Enter number check count of appearances: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The Number {0} has appeared {1} times", num,
                Appeaeances.TryGetValue(num, out int val) ? val : 0);
            q--;
        }
    }
}