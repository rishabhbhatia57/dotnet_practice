// Return the indices of elements of Array whose SUM return the target value

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the elements of Array: ");
        int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        Console.WriteLine("Enter the target value: ");
        int target = int.Parse(Console.ReadLine());
        int[] result = TwoSum(arr, target);
        Console.WriteLine(string.Join(",",result));
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for(int i=0;  i<nums.Length; i++)
        {
            int diff = target - nums[i];
            if (map.ContainsKey(diff))
            {
                return new int[] { map[diff], i };
            }
            map[nums[i]] = i;
        }

        return new int[0];
    }
}