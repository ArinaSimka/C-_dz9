// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetNumber(string message)
{
    Console.Write($"Введите неотрицательное число {message}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Akk(int n, int m)
{
    int a = 0;
    if (n==0)
    {
        a = m+1;
        return a;
    }
    else if (m==0)
    {
        a = Akk(n-1,1);
        return a;
            }
     else 
     {
        a = Akk(n-1, Akk(n,m-1));
         return a;
         }
}

int n = GetNumber("N");
int m = GetNumber("M");
 int a = Akk(n,m);
 System.Console.WriteLine($"A({n},{m})={a}");


