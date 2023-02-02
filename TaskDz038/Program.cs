/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2*/


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int nnumber = GetNumbers(numbers);
int min;
int max;



int GetNumbers(int[] numbers)
{

    
    //int difference = 0;
    for (int j = 0; j < numbers.Length; j++)
    {
        if (min > numbers[j])
        {
            min = numbers[j];
        }
        else if (max < numbers[j])
        {
         max = numbers[j];
        }

    }
    int difference = max - min;
    return difference;
}
 
Console.WriteLine($"всего {numbers.Length} чисел, разницу между максимальным и минимальным {nnumber}");


void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 100);
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
    min = numbers[0];
    max = numbers[0];
}
