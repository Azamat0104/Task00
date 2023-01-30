

Console.Write("Введите дипазон массива: ");
int a = Convert.ToInt32(Console.ReadLine());


int[] GenerateArray()
{
    
    int[] arr = new int[a];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 20);
        Console.Write(arr[i],5);
    }
    
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] array = GenerateArray();
PrintArray(array);