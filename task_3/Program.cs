/* Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

void cube (int x)
{
Console.Write($"Таблица кубов {x}: ");

for (int i = 1; i <= x; i++)
{
    if (i == x)
    {
        Console.WriteLine(Math.Pow (i,3));
        break;
    }
    Console.Write(Math.Pow (i,3) + ", ");
    
}
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

cube(number);