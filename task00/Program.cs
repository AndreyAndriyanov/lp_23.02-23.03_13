//0. демонстрация решения
// Напишите программу, которая
// 1. на вход принимает чисор и
// 2. выдаёт его квадрат (число умнодается на себя).

// Например :
// 3 -> 9
// -4 -> 16
// -7 -> 49
Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числa {number} = {square}");
//Console.WriteLine("Квадрат числa" + number, "=", + square);