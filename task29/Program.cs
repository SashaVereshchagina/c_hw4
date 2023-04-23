// Задача 29: Напишите программу, которая приниматет на вход длину массива,
//минимальное значение массива и максимальное значение массива, 
//создаёт массив с заданными параметрами и выводит значения на экран

//5, 1, 19 -> [1, 2, 5, 7, 19]

//3, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());

Console.WriteLine("Введите минимальное значение: ");
int min = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное значение: ");
int max = int.Parse(Console.ReadLine());

int[] array = new int [length];
fillArray(array);
printArray(array);

void fillArray (int[] array)

{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min,max);
    }
}

void printArray (int[] array)

{
    int length = array.Length;
    int count = 0;
    while (count < length-1)
    {
        Console.Write($"{array[count]}, ");
        count++;
    }
    Console.Write($"{array[count]}");
}