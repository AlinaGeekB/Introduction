/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

using System;
class Program
{
    static void Main(){
        Console.WriteLine("Введите три числа:");
        int a = Int32.Parse(Console.ReadLine());
        int b = Int32.Parse(Console.ReadLine());
        int c = Int32.Parse(Console.ReadLine());

         int maximal = Math.Max(Math.Max(a, b), c);
         int minimal = Math.Min(Math.Min(a, b), c);

         Console.WriteLine("{0} -> {1} -> {2}",
          minimal,
           a + b + c - maximal - minimal,
            maximal);
    }
} 



