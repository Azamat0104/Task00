void PrintArray (int[] array) 
{
   // Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    //Console.WriteLine("]");
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
System.Console.Write(" -> [");
PrintArray(arr);
System.Console.WriteLine("]");
