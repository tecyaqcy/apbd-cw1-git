public static class StatisticsHelper
{
    public static int CalculateSum(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be empty.");
        }

        int sum = CalculateSum(numbers);
        return (double)sum / numbers.Length;
    }
}