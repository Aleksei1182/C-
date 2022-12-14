// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координату х первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату х второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double DistanceBetweenPoints = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
/*Аналогичная запись по проще:
double DistanceBetweenPoints = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) +(z2 - z1)*(z2 - z1));
Math.Pow(X,2) возведение в степень (в данном случае в квадрат) числа "Х"
Math.Sqrt(a); вычисление корня квадратного из числа "а" */

Console.WriteLine(DistanceBetweenPoints);