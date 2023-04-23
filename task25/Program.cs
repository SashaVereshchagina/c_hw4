// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

int res = exponent(numberA, numberB);
Console.WriteLine(res);

int exponent(int numberA, int numberB)
{
    int result = 1;
    for (int i = 0; i < numberB; i++)
    {
        result *= numberA;
    }
    return result;
}