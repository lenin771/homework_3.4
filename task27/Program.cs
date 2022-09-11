// Задача 28: Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.

int FokCount(int number)
{
    int fok = 1;
    for (int i = 1; i <= number; i++)
    {
        fok = fok * i;
    }
    return fok;
}

Console.Write("Введите N: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"фоктериал числа равен {FokCount(number)}");
