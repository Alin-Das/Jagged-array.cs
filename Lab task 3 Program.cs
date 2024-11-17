using System;

class Program
{
    static void Main()
    {
        int[][][] grades = new int[][][]
        {
            new int[][] { new int[] { 85, 90, 78 }, new int[] { 88, 92, 95 } }, 
            new int[][] { new int[] { 76, 81, 69 }, new int[] { 93, 87, 84 } }, 
            new int[][] { new int[] { 89, 91, 85 }, new int[] { 77, 79, 82 } }  
        };

        Console.WriteLine("All Grades:");
        for (int i = 0; i < grades.Length; i++)
        {
            Console.WriteLine($"Department {i + 1}:");
            for (int j = 0; j < grades[i].Length; j++)
            {
                Console.Write("  Course " + (j + 1) + ": ");
                for (int k = 0; k < grades[i][j].Length; k++)
                {
                    Console.Write(grades[i][j][k] + " ");
                }
                Console.WriteLine();
            }
        }

        Console.WriteLine("\nAverage Grades:");
        for (int i = 0; i < grades.Length; i++)
        {
            Console.WriteLine($"Department {i + 1}:");
            for (int j = 0; j < grades[i].Length; j++)
            {
                int sum = 0;
                for (int k = 0; k < grades[i][j].Length; k++)
                {
                    sum += grades[i][j][k];
                }
                int average = sum / grades[i][j].Length;
                Console.WriteLine($"  Course {j + 1}: {average}");
            }
        }

        Console.WriteLine("\nHighest Grades:");
        for (int i = 0; i < grades.Length; i++)
        {
            int highest = 0;
            for (int j = 0; j < grades[i].Length; j++)
            {
                for (int k = 0; k < grades[i][j].Length; k++)
                {
                    if (grades[i][j][k] > highest)
                    {
                        highest = grades[i][j][k];
                    }
                }
            }
            Console.WriteLine($"Department {i + 1}: {highest}");
        }
    }
}
