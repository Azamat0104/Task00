/*17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка.

Console.WriteLine("Введите координате точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(x, y);
string result = quarter > 0? $"Указанные координаты соответствуют четверти -> {quarter}"
        :"Введены некорректные координаты";
    Console.WriteLine(result);

int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}

Math.Pow(2, 10);
Math.Sqrt(5);
double d = 5.09997623455;
double dRuynd = Math.Round(d, 2, MidpointRounding.ToZero);
System.Console.WriteLine(dRuynd);*/


/*Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер плоскости: ");
string number = Console.ReadLine();

string quarter = Quarter(number);

Console.WriteLine(quarter);

string Quarter(string num)
{
    // if(xc > 0 && yc > 0) return 1;
    // if(xc < 0 && yc > 0) return 2;
    // if(xc < 0 && yc < 0) return 3;
    // if(xc > 0 && yc < 0) return 4;
    // return 0;

    // if (num == "1") return "Допустимые координаты: x > 0 и y > 0";
    // if (num == "2") return "Допустимые координаты: x < 0 и y > 0";
    // if (num == "3") return "Допустимые координаты: x < 0 и y < 0";
    // if (num == "4") return "Допустимые координаты: x > 0 и y < 0";
    // return "Неккоректный ввод!";

    switch (num)
    {
        case "1": return "Допустимые координаты: x > 0 и y > 0";
        case "2": return "Допустимые координаты: x < 0 и y > 0";
        case "3": return "Допустимые координаты: x < 0 и y < 0";
        case "4": return "Допустимые координаты: x > 0 и y < 0";
        default: return "Неккоректный ввод!";
    }
}*/

/*Напишите программу, которая:
1. принимает на вход координаты двух точек 
2. и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21*/

/*Console.WriteLine("Укажите координаты первой точки");
int numx1 = Convert.ToInt32(Console.ReadLine());
int numy1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите координаты второй точки");
int numx2 = Convert.ToInt32(Console.ReadLine());
int numy2 = Convert.ToInt32(Console.ReadLine());

double Distance(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
}

double distance = Distance(numx1, numy1, numx2, numy2);
distance = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine(distance);*/


Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Некорректный ввод");
else Table(number);


void Table(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,5}   {count * count,5}");
        count++;
    }
}

