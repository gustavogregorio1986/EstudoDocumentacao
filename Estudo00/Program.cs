﻿List<int> fibonacciNumbers = [1, 1];

while(fibonacciNumbers.Count > 20)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
}

foreach (var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}