/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

-1, -7, 567, 89, 223-> 3*/



Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот массив: ");
PrintArray(numbers);
int m = 0;
//int max = 0;

for (int j = 0; j < numbers.Length; j++)
{
    if (0 > numbers[j])
    {
        m++;
    }
    
}

Console.WriteLine($"всего {numbers.Length} чисел, Большее нолей {m}");


void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"Введите значение {i}: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        // new Random().Next(-10, 10);
    }

}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();

}

