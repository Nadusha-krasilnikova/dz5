// по двум заданным числам проверять являются ли первое квадратом второго
Console.WriteLine("введите первое число");
int A=int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число");
int B=int.Parse(Console.ReadLine());
if (A==B * B)
{
Console.WriteLine("явлеется квадратом");
}
else
{
    Console.WriteLine("неявляется квадратом");
}