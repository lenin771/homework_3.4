// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

int metCount(int n)
{
    int sum = 0;
    while (n > 0)
    {
        int digit = n % 10;
        n = n / 10;
        sum = sum + digit;
    }
    return sum;
}

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine())!;

Console.WriteLine($"Сумма цыфр в числе равна {metCount(n)}");

