using System;

class Program
{
    static void Main()
    {
		int[,] grades =
			{
			{98,90,98},
			{90,98,96},
			{90,98,86}
		};
		int students = grades.GetLength(0);
		int subjects = grades.GetLength(1);

		Console.WriteLine("Studemts Grades: ");
		for (int i = 0; i < students; i++)
		{
			Console.Write("Students " + (i + 1) + ":");
			for (int j = 0; j < subjects; j++)
			{
				Console.Write(grades[i, j] + " ");

				Console.WriteLine();
			}

			Console.WriteLine("\nAverage per student: ");
			for (int i = 0; i < students; i++)
			{
				int sum = 0;
				for (int j = 0; j < subjects; j++) sum += grades[i, j];
				Console.Write($"Students {i + 1}:  {(double)sum / students:F2}");
			}

			Console.WriteLine("\nAverage per sub: ");
			for (int j = 0; j < subjects; j++)
			{
				int sum = 0;
				for (int i = 0; i < students; i++) sum += grades[i, j];
				Console.Write($"Students {i + 1}: {(double)sum / students:F2}");
			}
		}

	}
}
}

    }