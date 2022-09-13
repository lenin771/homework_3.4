// Задача 29: Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.

Console.WriteLine("Введите 8 элементов массива через пробел");
string elementsArray = Console.ReadLine();
string[] elementsSplit = elementsArray.Split(' ');
int[] array = new int[elementsArray.Length];

for (int i = 0; i < elementsSplit.Length; i++)
{
    array[i] = int.Parse(elementsSplit[i]);
    Console.Write($"{array[i]}{' '}");
}
Console.WriteLine();
