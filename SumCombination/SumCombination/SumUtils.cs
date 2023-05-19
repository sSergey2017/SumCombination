namespace SumCombination;

public static class SumUtils
{
    public static bool HasSumCombination(List<int> numbers, int targetSum)
    {
        HashSet<int> complements = new HashSet<int>();

        foreach (int num in numbers)
        {
            int complement = targetSum - num;
            if (complements.Contains(complement))
            {
                return true;
            }
            complements.Add(num);
        }

        return false;
    }
}