/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/



Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());



int SumNumber(int numberN)
{

    int variable;
    int result = 0;
    int n;
    if (numberN > 999)
    {
        n = 4;
    }
    else
    {
        n = 3;
    }
    
    for (int i = 0; i < n; i++)
    {
        variable = numberN - numberN % 10;
        result = result + (numberN - variable);
        numberN = numberN / 10;
    }
    return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);



