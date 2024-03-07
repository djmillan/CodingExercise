namespace CodingExercise
{
    internal class Solution
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the Coding Exercise!");

                Console.Write("Enter how many integers you are about to input >> ");
                int lengthOfArray = Convert.ToInt32(Console.ReadLine());

                int[] nums = new int[lengthOfArray];
                Console.Write("Enter the target integer >> ");

                int target = Convert.ToInt32(Console.ReadLine());

                int count = 1;
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write($"Enter the integer for #{count + i} >> ");
                    nums[i] = int.Parse(Console.ReadLine());
                }
                Console.Write("Values: ");
                foreach (int i in nums)
                {
                    Console.Write($"{i} ");
                }
                TwoSum(nums, target);
                Console.WriteLine(nums);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            throw new ArgumentException("No solution.");
        }
    }
}
