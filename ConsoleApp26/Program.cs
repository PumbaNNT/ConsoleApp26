using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4, 2, 5, 6, 1 };

        int even = a.Count(x => x % 2 == 0);
        int odd = a.Count(x => x % 2 != 0);
        int unique = a.Distinct().Count();

        Console.WriteLine("Парних: " + even);
        Console.WriteLine("Непарних: " + odd);
        Console.WriteLine("Унікальних: " + unique);
    }
}



using System;

class Program
{
    static void Main()
    {
        int[] A = new int[5];
        double[,] B = new double[3, 4];
        Random r = new Random();

        for (int i = 0; i < A.Length; i++)
        {
            Console.Write("A[" + i + "] = ");
            A[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 4; j++)
                B[i, j] = r.Next(-10, 11) + r.NextDouble();

        Console.WriteLine("Масив A:");
        foreach (int x in A)
            Console.Write(x + " ");

        Console.WriteLine("\nМасив B:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
                Console.Write(B[i, j].ToString("F2") + "\t");
            Console.WriteLine();
        }

        double max = A[0];
        double min = A[0];
        double sum = 0;
        double product = 1;
        int evenSum = 0;
        double oddColumnsSum = 0;

        foreach (int x in A)
        {
            if (x > max) max = x;
            if (x < min) min = x;
            sum += x;
            product *= x;

            if (x % 2 == 0)
                evenSum += x;
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                double x = B[i, j];

                if (x > max) max = x;
                if (x < min) min = x;

                sum += x;
                product *= x;

                if (j % 2 == 0)
                    oddColumnsSum += x;
            }
        }

        Console.WriteLine("Максимум: " + max);
        Console.WriteLine("Мінімум: " + min);
        Console.WriteLine("Загальна сума: " + sum);
        Console.WriteLine("Загальний добуток: " + product);
        Console.WriteLine("Сума парних елементів A: " + evenSum);
        Console.WriteLine("Сума непарних стовпців B: " + oddColumnsSum);
    }
}



using System;

class Program
{
    static void Main()
    {
        int[,] a = new int[5, 5];
        Random r = new Random();
        int min = 100;
        int max = -100;
        int minIndex = 0;
        int maxIndex = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                a[i, j] = r.Next(-100, 101);
                Console.Write(a[i, j] + "\t");

                int index = i * 5 + j;

                if (a[i, j] < min)
                {
                    min = a[i, j];
                    minIndex = index;
                }

                if (a[i, j] > max)
                {
                    max = a[i, j];
                    maxIndex = index;
                }
            }

            Console.WriteLine();
        }

        int start = Math.Min(minIndex, maxIndex);
        int end = Math.Max(minIndex, maxIndex);
        int sum = 0;

        for (int i = start + 1; i < end; i++)
            sum += a[i / 5, i % 5];

        Console.WriteLine("Мінімум: " + min);
        Console.WriteLine("Максимум: " + max);
        Console.WriteLine("Сума між мінімумом і максимумом: " + sum);
    }
}



using System;

class Program
{
    static void Main()
    {
        int[] a = { 5, 10, 15, 7, 12, 5, 9, 20 };
        int min = a[0];
        int count = 0;

        foreach (int x in a)
            if (x < min)
                min = x;

        foreach (int x in a)
            if (x - min == 5)
                count++;

        Console.WriteLine("Мінімальний елемент: " + min);
        Console.WriteLine("Кількість елементів, що відрізняються на 5: " + count);
    }
}
