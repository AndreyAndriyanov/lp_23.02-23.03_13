// напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее 


Console.WriteLine("Введите первое число: " );
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: " );
int numB = Convert.ToInt32(Console.ReadLine());
if(numA > numB)
{
    Console.WriteLine($"Первое число больше второго" (numA) ,">", (numB));
}

if(numB>numA)
{
    Console.WriteLine($"Второе число больше первого" (numB) ,">" (numB));
}

if(numA==numB)
{
    Console.WriteLine($"числа равны друг другу" (numA) ,"=", (numB));
}