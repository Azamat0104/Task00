/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/


Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
int finishNumber = GetNumber(number);

int GetNumber(int number)
{


    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result;

}

if (GetNumber(number) == -1)
Console.WriteLine("третьей цифры нет");
else
Console.WriteLine($"{GetNumber(number)}");