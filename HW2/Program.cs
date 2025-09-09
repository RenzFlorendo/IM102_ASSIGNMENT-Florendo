using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter row: ");
        int rowCount = int.Parse(Console.ReadLine());

        Console.Write("Enter col: ");
        int colCount = int.Parse(Console.ReadLine());

        List<List<double>> numbers = new List<List<double>>();

        for (int row = 0; row < rowCount; row++)
        {
            Console.WriteLine($"Row {row + 1}");
            List<double> currentRow = new List<double>();

            for (int col = 0; col < colCount; col++)
            {
                Console.Write($"Enter number {col + 1}: ");
                double num = double.Parse(Console.ReadLine());
                currentRow.Add(num);
            }

            numbers.Add(currentRow);
        }

        Console.WriteLine("\nThe numbers are:");
        double total = 0;
        int totalCount = 0;

        foreach (var row in numbers)
        {
            foreach (var num in row)
            {
                Console.Write($"{num} ");
                total += num;
                totalCount++;
            }
            Console.WriteLine();
        }

        double average = total / totalCount;
        Console.WriteLine($"\nSum: {total} ; Average: {average}");

        
       
        Console.ReadKey();
    }
}
