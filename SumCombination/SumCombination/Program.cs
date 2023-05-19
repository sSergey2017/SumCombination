using SumCombination;

List<int> numbers = new List<int> { 5, 1, 2, 7, 8 };
int targetSum = 13;

bool hasSumCombination = SumUtils.HasSumCombination(numbers, targetSum);

Console.WriteLine(hasSumCombination);




