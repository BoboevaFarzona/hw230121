using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            // homework 1

            //задание 2
            //           int A = 1, B = 10, sum = 0;

            //           for (int i = A + 1; i < B; i++)
            //           {
            //               {
            //                   sum += i;

            //               }
            //               Console.WriteLine(sum);


            //           }
            //           int A = 1, B = 10, sum = 0;

            //           for (int i = A + 1; i < B; i++)
            //           {
            //               if (i % 2 == 1)
            //               {
            //                   Console.WriteLine(i);
            //               }
            //           }
            // задание2
            //Прямоугольник 

            //for (int i = 0; i < 5; i++)
            //{
            //    if (i == 0 || i == 4)
            //    {
            //        for (int j = 0; j < 10; j++)
            //            Console.Write("*");
            //    }
            //    else
            //    {
            //        Console.Write("*");
            //        for (int k = 1; k < 9; k++)
            //            Console.Write(" ");
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}
            //Console.WriteLine();
            //// Прямоугольный треугольник 
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (j == 0 || j == i || i == 9)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.Write("\n");
            //}
            //Console.WriteLine();
            //// Равносторонний треугольник 
            //var tx = 9;
            //var ty = 9;
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < (10 * 2) - 1; j++)
            //    {
            //        if (j == tx || j == ty || i == 9)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    tx--;
            //    ty++;
            //    Console.Write("\n");
            //}
            //Console.WriteLine();
            //// ромб
            //for (int i = 9; i >= -9; i--)
            //{
            //    for (int j = 1; j <= Math.Abs(i); j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 9; k >= Math.Abs(i); k--)
            //    {
            //        if (k == 9 || k == Math.Abs(i))
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.Write("\n");
            //}
            //Console.WriteLine();


            ////           //задание 3
            //double k=1, s = 1000;
            //    int month=0;
            //    var p = Convert.ToInt32(Console.ReadLine());
            //while (s <= 1100)
            //{

            //    s += s * p / 100;
            //    month++;


            //}

            //Console.WriteLine($"Month = {month}");
            //Console.WriteLine($"s = {s}");
            //Console.ReadKey();

            //// homework 2
            // 1
            //Console.Write("N = ");
            //int.TryParse(Console.ReadLine(), out var N);
            //var arr = new int[N];
            //Random r = new Random();
            //for (var i = 0; i < N; i++)
            //{
            //    arr[i] = r.Next(1, 99);
            //    Console.Write($"{arr[i]} ");
            //}
            //Console.WriteLine();
            //var mx = arr[0];
            //var mn = arr[0];
            //var sum1 = arr[0];
            //for (int i = 1; i < N; i++)
            //{
            //    mx = Math.Max(arr[i], mx);
            //    mn = Math.Min(arr[i], mn);
            //    sum1 += arr[i];
            //}
            //Console.WriteLine($"max = {mx}");
            //Console.WriteLine($"min = {mn}");
            //Console.WriteLine($"sum = {sum1}");
            //Console.WriteLine($"average = {sum1 / N}");
            //for (int i = 0; i < N; i++)
            //    if (arr[i] % 2 != 0)
            //        Console.Write($"{arr[i]} ");

            //           //2
            //           int[] numbers = { 0, 1, 2, 3, 4, 5 };
            //           Array.Reverse(numbers);
            //           Array.Resize(ref numbers, 5);
            //           foreach (int number in numbers)
            //           {
            //               Console.WriteLine($"{number}\t ");
            //           }

            // 3
            //int userSize = Convert.ToInt32(Console.ReadLine());
            //int[] number = new int[userSize];
            //Random rnd = new Random();
            //for (int i = 0; i < number.Length; i++)
            //{
            //    number[i] = rnd.Next(1000);
            //}
            //foreach (var numbers in number)
            //{
            //    Console.WriteLine(numbers);
            //}
            //var count = Convert.ToInt32(Console.ReadLine());
            //var index = Convert.ToInt32(Console.ReadLine());
            //int[] empty = new int[count];
            //for (int d = 0; d < empty.Length; d++)
            //{
            //    if (d + index < number.Length)
            //        empty[d] = number[d + index];

            //    else
            //        empty[d] = 1;
            //}
            //for (int d = 0; d < empty.Length; d++)
            //{
            //    Console.WriteLine(empty[d]);
            //}


            //у меня были сложности на счет дз1-3, дз2 -4 еще я не очень то хорошо поняла цикл в цикле 
            //еще мне нужно практиковаться могли б рекомендовать учебники
        }
    }
}