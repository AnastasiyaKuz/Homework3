/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

Console.Write("Введите 5-ти значное число");
string num = Console.ReadLine();
int Length = num.Length;
if (Length == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"{num} является палиндромом");
    }
    else
    {
        Console.WriteLine($"{num} НЕ является палиндромом");
    }
}   
else
{
    Console.WriteLine("Введено не 5-ти значное число");
}
