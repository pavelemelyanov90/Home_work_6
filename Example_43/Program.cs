// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.


Console.WriteLine("Ведите k1:\t");
double num1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Ведите b1:\t");
double num2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Ведите k2:\t");
double num3 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Ведите b2:\t");
double num4 = double.Parse(Console.ReadLine()!);

double x = (num2 - num4)/(num3 - num1); // x = (b1-b2)/(k2-k1)
double y = (num3 * num2 - num1 * num4) / (num1 - num3); // y = (k2*b1-k1*b2)/(k2-k1)
if(num1 == num3)
{
    Console.WriteLine("Прямые параллельны или совпадают");
}
else
{
    Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}

