// Задача 29: Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.

// Для массива размерность которого указывает пользователь
// Console.Write("Введите количество элементов массива:\t");
// int elementsCount = int.Parse(Console.ReadLine());

int[] array = new int[8];  // int[] array = new int[elementsCount];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"\nВведите элемент массива с индексом {i}:\t");
    array[i]= int.Parse(Console.ReadLine());
}
Console.WriteLine("\nВывод массива");

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

