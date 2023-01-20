// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
double num_2 = num % 2;
if (num_2 == 0)
    Console.WriteLine($"{num} -> да");
else
    Console.WriteLine($"{num} -> нет");