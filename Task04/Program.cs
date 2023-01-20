// Задача 4: Напишите программу, которая принимает на 
// вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите первое число:"); 
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.WriteLine($"{num1}, {num2}, {num3} -> {max}!");

// ВТОРОЙ ВАРИАНТ НАШЕЛ В ИНТЕРНЕТЕ, НО Я ЕГО НЕ ПОНЯЛ!!! 
// НО ВИДИМО МЫ ЭТО ЕЩЕ НЕ ПРОХОДИЛИ!
// Я ЭТОТ КОД НА БУДУЩЕЕ СОХРАНИЛ, ЧТОБЫ ИЗУЧИТЬ!

// string[] i = Console.ReadLine().Split(' ');
// int a = Convert.ToInt32(i[0]);
// int b = Convert.ToInt32(i[1]);
// int c = Convert.ToInt32(i[2]);
// Console.WriteLine(Math.Max(a, Math.Max(b, c)));