/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/


int userNumber1 = new int ();
int userNumber2 = new int ();
Console.WriteLine ("Введите 2 числа");
    userNumber1 = Convert.ToInt32 (Console.ReadLine());
    userNumber2 = Convert.ToInt32 (Console.ReadLine());
if (userNumber1>userNumber2)
    {Console.WriteLine("большее=" + userNumber1);
    Console.WriteLine("меньшее=" + userNumber2);}
else
{Console.WriteLine("большее=" + userNumber2);
Console.WriteLine("меньшее=" + userNumber1);  
}


