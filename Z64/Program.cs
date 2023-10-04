// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetNumber(string message)
{
    Console.Write($"Введите значение {message}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void NatNumberRek(int n)
{
    if (n==0)
    {
        return;
    }
    if (n>0)
    {
       Console.Write($"{n}  ");
    }
    NatNumberRek(n-1);
}

int n = GetNumber("N");
NatNumberRek(n);


