﻿/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Write("Введите 1 число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3 число:");
int number3 = Convert.ToInt32(Console.ReadLine());
int max;

if( number1 > number2)
{
    max = number1;
       
}
else 
{
    max = number2;
}
if(number3 > max)
{
    max = number3;
}
Console.Write("Максимальное число " + max);
