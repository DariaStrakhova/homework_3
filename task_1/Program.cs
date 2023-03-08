/* Задача 19. Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 ->да
*/

int palindrom(int x)
{
    while (x < 9999 || x > 100000) 
{
    Console.WriteLine("Число не является пятизначным");
    Console.Write("Введите пятизначное число: ");
    x = int.Parse(Console.ReadLine());   
}

    int five = x % 10;
    int four = (x % 100 - five) / 10;
    int one = x / 10000;
    int two = x / 1000 - one * 10;
   
    
    Console.WriteLine($"Первое число: {one}");
    Console.WriteLine($"Второе число: {two}");
    Console.WriteLine($"Четвертое число: {four}");
    Console.WriteLine($"Пятое число: {five}");
    Console.WriteLine(" ");
    

    if (one == five && two == four)
    {
        Console.Write($"Да, {x} - это палиндром");
    }
    else
    {
        Console.WriteLine($"Нет, {x} - это не палиндром");
    }
    return 0;
}

Console.Write("Введите пятизначное число : ");
int fivedigit = int.Parse(Console.ReadLine());

palindrom(fivedigit);