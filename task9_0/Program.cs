// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool Verificate(int N, int M)
{
if(N < M) 
{System.Console.WriteLine("число M больше N, введите другие числа");
 return false;
}
return true;
}

void Shownumbers(int M, int N)
{
    if (M > N) return;
if (M%2 == 0) System.Console.Write($" {M} "); 
{
  Shownumbers(M + 1, N);
}
}

int M = ReadInt("Введите число M > ");
int N = ReadInt("Введите число N > ");
if (Verificate(N,M))
System.Console.WriteLine();
Shownumbers(M, N);