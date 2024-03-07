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
                Console.WriteLine($"\n{i},{j}");
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
            // Return an array of -1 if no indices were found.
            return new int[] { -1, -1 };
            throw new ArgumentException("No solution.");
        }
    }
}
/*
 * using System;

public class TwoSumExample
{
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
        // Return an array with -1 if no such indices are found
        return new int[] { -1, -1 };
    }

    public static void Main()
    {
        Console.WriteLine("Enter the target sum:");
        int targetSum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the length of the array:");
        int length = Convert.ToInt32(Console.ReadLine());
        int[] inputNums = new int[length];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < length; i++)
        {
            inputNums[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] resultIndices = TwoSum(inputNums, targetSum);

        if (resultIndices[0] != -1)
        {
            Console.WriteLine("Indices of the numbers adding up to the target sum:");
            Console.WriteLine("Index 1: " + (resultIndices[0] + 1)); // Adding 1 to make it more user-friendly
            Console.WriteLine("Index 2: " + (resultIndices[1] + 1)); // Adding 1 to make it more user-friendly
        }
        else
        {
            Console.WriteLine("No such indices found that add up to the target sum.");
        }
    }
}
*/