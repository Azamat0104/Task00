/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/


Console.Write("Введите положительное натуральное число: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int GetNumber(int num)
{
    int secondNum = 0;
    while(num>0)
    {
        secondNum = secondNum * 10 + num % 10;
        num /=10;
    }
    return secondNum;
}


while (userNum < 0)
{
    Console.Write("отрицательное число не может быть палиндромом. Введите положительное натуральное число: ");
    userNum = Convert.ToInt32(Console.ReadLine());
}

int result = GetNumber(userNum);
Console.WriteLine(result == userNum ? $"Число {userNum} - да" : $"Число {userNum} - нет");