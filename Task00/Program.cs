﻿//  0. Демонстрация решения

//  Напишите программу, которая 
// 1. на вход принимает число 
// 2. и выдаёт его квадрат (число умноженное на само себя).
// 3. Вывод результата
//  Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("введите целое число:");
int number1 = Convert.ToInt32(Console.ReadLine()); //25 
int number2 = Convert.ToInt32(Console.ReadLine()); // 5
int square = number2 * number2;
if (number1 == square )
{
    Console.WriteLine("да");
}
else{
    Console.WriteLine("нет");
}
//Console.WriteLine($"Квадрат числа {number} =  {square}");


// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
