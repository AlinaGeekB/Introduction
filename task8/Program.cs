/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

int getNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int GetPalindrome (int userNumber)
{
    int Numb1 = userNumber / 10000;
    int Numb2 = (userNumber / 1000) % 10;
    int Numb4 = (userNumber / 10) % 10;
    int Numb5 = userNumber % 10;
    if (Numb1 == Numb5) 
    {
        if (Numb2 == Numb4)
        {
            Console.WriteLine($"Число {userNumber} - является палиндром");
        }
    }
    else
    {
        Console.WriteLine($"Число {userNumber} - не является палиндромом");
    }
     return userNumber;
}
int userNumber = getNumberFromUser("Введите пятизначное число: ");
Console.WriteLine();
int Number = GetPalindrome(userNumber);
Console.WriteLine();
Console.WriteLine("ВНИМАНИЕ! Программа работает только при вводе пятизначного числа!)");

