/*9. Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8*/


/*int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99=>{number}");

int firstDigit = number / 10; // 7
int secondDigit = number % 10; // 8
if (firstDigit > secondDigit)
    Console.WriteLine($"Наибольшая цифра числа => {firstDigit}");
else
    Console.WriteLine($"Наибольшая цифра числа => {secondDigit}");

    int maxDigit = MaxDigit(number);
    Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10; // 7
    int secondDigit = num % 10; // 8
    if(firstDigit > secondDigit) return firstDigit;
    else return secondDigit;
}*/

/*Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98

int rendomNumber = new Random().Next(100, 1000);
Console.WriteLine($"Конечное число => {rendomNumber}");
int finishNumber = GetNumber(rendomNumber);
Console.Write($"Конечное число => {finishNumber}");

int GetNumber(int number)
{
    int firstNumber = number / 100;
    int secondNumber = number % 10;

    int result = firstNumber * 10 + secondNumber;
    return result;
}
*/

/*14. Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да



Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = GetNumber(number);

int GetNumber(int num)
{
    int res1 = num % 7;
    int res2 = num % 23;
    if (res1 == 0 && res2 == 0) return 1;
    else return 0;
}

if (result == 1) Console.WriteLine("Кратно 7 и 23");
else Console.WriteLine("Не кратно 7 и 23");*/

/*16. Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет

Console.Write("Введите целое первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = GetNumber(firstNumber, secondNumber);

int GetNumber(int num1, int num2)
{
    if (num1 * num1 == num2) return 1;
    else if (num2 * num2 == num1) return 1;
    else return 0;
}

if (result == 1) Console.WriteLine("Кратно");
else Console.WriteLine("Некратно");*/