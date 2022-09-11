// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

Console.Write("Введите число возводимое в степень: ");
int number = int.Parse(Console.ReadLine()!);

Console.Write("Введите сепень: ");
int degree = int.Parse(Console.ReadLine()!);
double pow = 1;

if (degree > 0)
    for (int i = 1; i <= degree; i++)
    {
        pow = pow * number;
    }
else
{
    for (int i = 1; i <= Math.Abs(degree); i++)
    {
        pow = pow * number;
    }
    pow = 1 / pow;
}
Console.WriteLine($"число {number} возведенное в степень {degree} равно {pow}");

