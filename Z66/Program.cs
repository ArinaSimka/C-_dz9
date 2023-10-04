// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string message)
{
    Console.Write($"Введите значение {message}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SummaNumberRek(int m, int n)
{
int sum = n;
    if ( m>n || n==m)
    {
        return sum;
    }
    if (n>m )
    {
         sum = sum + SummaNumberRek(m, n-1); 
    }
   
           return sum;
}


int sum = SummaNumberRek(m,n);
Console.WriteLine(sum);