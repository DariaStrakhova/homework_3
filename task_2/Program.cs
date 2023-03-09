/* Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

double Coordinate3D(double x_1, double y_1, double z_1, double x_2, double y_2, double z_2)
{
double ans = Math.Sqrt( Math.Pow((x_2 - x_1), 2) + Math.Pow((y_2 - y_1), 2) + Math.Pow((z_2 - z_1), 2));
Console.Write("Расстояние между точками в 3D пространстве: ");
Console.WriteLine(ans);
return 0;
}


Console.WriteLine("Введите координату А1 ");
double A1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату А2 ");
double A2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату А3 ");
double A3 = double.Parse(Console.ReadLine());

Console.WriteLine("");

Console.WriteLine("Введите координату B1 ");
double B1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату B2 ");
double B2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату B3 ");
double B3 = double.Parse(Console.ReadLine());

Console.WriteLine("");

Coordinate3D(A1,A2,A3,B1,B2,B3);
