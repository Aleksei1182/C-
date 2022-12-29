// Напишите программу, которая найдёт точку пересечения двух прямых на плоскости, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение k1 для первого уровения y = k1 * x + b1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b1 для первого уровения y = k1 * x + b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2 для второго уровения y = k2 * x + b2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2 для второго уровения y = k2 * x + b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2 && b1 == b2) Console.Write("Для заданных значений прямые совпадают");
else if (k1 == k2) Console.Write ("Для заданных значений прямые паралельны");
else 
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.Write ("Для заданных значений прямые пересекаются в точке (" + x + ";" + y + ")");
}
//в данной задаче не вижу смысла делать через метод