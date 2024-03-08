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
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Values: ");
                foreach (int i in nums)
                {
                    Console.Write($"{i} ");
                }
                int[] resultIndices = TwoSum(nums, target);
                
                Console.WriteLine($"Output: ["+resultIndices[0]+","+resultIndices[1]+"]");
                Console.Write("Explanation: Because nums["+resultIndices[0]+"] + nums["+resultIndices[1]+"] == "+target+", we return ["+resultIndices[0]+","+resultIndices[1]+"]");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static int[] TwoSum(int[] nums, int target)
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
