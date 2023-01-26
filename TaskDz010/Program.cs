//int number = new Random().Next(10, 100);
/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введи трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int finishNumber = GetNumber(number);
//Console.Write($"Середине число => {finishNumber}");

int GetNumber(int number)
{
    if (number < 1000){
    int result = (number / 10) % 10;
    return result;}
    else {
        return -1;
    }
}
if (finishNumber == -1)
{
    Console.WriteLine("Error");
}
else{
    Console.Write($"Середине число => {finishNumber}");
}

