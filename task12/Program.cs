/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/


int getNumberFromUser(string message)
{
    int result = 0;
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(message);
    Console.ResetColor();
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int getSumma (int userNumber)
{
    int sum = 0;
    for (int i = userNumber; i > 0;)
    {
        sum = sum + i % 10; 
        i = i / 10;            
    } 
    return sum;
}
int userNumber = getNumberFromUser ("Введите число:");
int sum = getSumma (userNumber);
Console.WriteLine($"Сумма цифр в числе {userNumber} = {sum} "); 
