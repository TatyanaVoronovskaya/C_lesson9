// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool Verificate(int n, int m)
{
if(n < 0 || m < 0) 
{System.Console.WriteLine("Вы ввели отрицательное число");
 return false;
}
return true;
}

int FnAkkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return FnAkkerman(m -1, 1);
else return FnAkkerman(m - 1, FnAkkerman(m, n - 1));
}

int m = ReadInt("ведите число m > ");
int n = ReadInt("ведите число n > ");
Verificate(n, m);
System.Console.Write($"Функция Аккермана = {FnAkkerman(m, n)}");