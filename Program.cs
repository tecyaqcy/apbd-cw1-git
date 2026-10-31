using System;

int[] numbers = { 2, 4, 6 };

Console.WriteLine(Greeting.GetMessage());
Console.WriteLine($"Sum: {StatisticsHelper.CalculateSum(numbers)}");
Console.WriteLine($"Average: {StatisticsHelper.CalculateAverage(numbers)}");
Console.WriteLine($"Number of elements: {numbers.Length}");