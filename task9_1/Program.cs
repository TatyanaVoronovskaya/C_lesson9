// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool Verificate(int n, int m)
{
if(n < m) 
{System.Console.WriteLine("число N больше M, введите другие числа");
 return false;
}
return true;
}

int sum = 0;

int SumNumber(int n, int m)
{
        sum = sum + (m);
        if (m >= n) return sum;
    return SumNumber(n, m + 1);
}

int n = ReadInt("Введите число N > ");
int m = ReadInt("Введите число M > ");
if (Verificate(n,m))
System.Console.WriteLine ($"сумма чисел от {m} до {n} = {SumNumber (n, m)}");
