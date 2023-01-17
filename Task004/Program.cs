int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if(max < number2)
{
    max = number2;
}
else if(max < number3) 
{
    max = number3;
    Console.Write(max);
}