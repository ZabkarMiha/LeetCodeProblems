TwoSum(new int[] { 0, 4, 3, 0 }, 0);

int[] TwoSum(int[] nums, int target)
{
    int num1;
    List<int> solution = new List<int>();
    for (int i = 0; i < nums.Length - 1; i++)
    {
        num1 = nums[i];
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (num1 + nums[j] == target)
            {
                solution.Add(i);
                solution.Add(j);
            }
        }
    }

    Console.WriteLine(solution[0] + " " + solution[1]);
    return solution.ToArray();
}