double numA, numB;
Console.WriteLane("Введите большее целое число");
numA = double.Parse(Console.ReadLane());
Console.WriteLine("Введите меньшее целое число");
numB = double.Parse(Console.ReadLine());
double index = 1;
if(index==numA/(numB*numB))
{
    Console.WriteLine("Квадратом является");   
}
else
{
    Console.WriteLine("Квадратом не является");

}