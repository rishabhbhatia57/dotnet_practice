public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the elements of Array 1: ");
        int[] arr1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        Console.WriteLine("Enter the elements of Array 2: ");
        int[] arr2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        bool result = CheckTwoArrayEqual(arr1, arr2);
        Console.WriteLine("Array 1 and Array2 are equal: {0}", result);
    }

    public static bool CheckTwoArrayEqual(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            return false;
        }
        else
        {
            Dictionary<int, int> map = new Dictionary<int, int> ();

            for(int i=0;i<arr1.Length; i++)
            {
                if (map.ContainsKey(arr1[i]))
                {
                    map[arr1[i]] += 1; 
                }
                else
                {
                    map.TryAdd(arr1[i], 1);
                } 
            }
            for (int j = 0; j < arr2.Length; j++)
            {
                if (!map.ContainsKey(arr2[j]))
                {
                    return false;
                }
                map[arr2[j]] -= 1;
            }
            foreach (var pair in map)
            {
                Console.WriteLine($"key: {pair.Key} and value {pair.Value}");
            }
            foreach (var pair in map)
            {
                if(pair.Value != 0)
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}