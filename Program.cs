/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные
числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

// int n = 0;
// Console.WriteLine("Enter n: ");   
// n = Convert.ToInt32(Console.ReadLine());

// void ShowNumbers(int n)
// {
//     if (n>1) ShowNumbers(n-1);
//     Console.Write(n+" ");
// }

// ShowNumbers(n);

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


// int n, m, sum = 0;
// Console.WriteLine("Enter n: ");   
// n = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Enter m: ");   
// m = Convert.ToInt32(Console.ReadLine()); 

// void ShowNumSum(int n, int m)
// {
//     if (n != m) ShowNumSum(Math.Min(n,m), Math.Max(n,m)-1);
//     sum = sum + Math.Max(n,m);
// }

// ShowNumSum (n, m);
// Console.Write (sum);

/* Задача 68*: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

// int n, m = 0;
// Console.WriteLine("Enter n: ");   
// n = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Enter m: ");   
// m = Convert.ToInt32(Console.ReadLine());

// int Ack(int m, int n)
// {
// if (m == 0)
// 		{
// 			return n + 1;
// 		}
// 		else if((m > 0) && (n == 0))
// 		{
// 			return Ack(m - 1, 1);
// 		}
// 		else if((m > 0) && (n > 0))
// 		{
// 			return Ack(m - 1, Ack(m, n - 1));
// 		}else
// 		return n + 1;
// }

// Ack(m,n);
// Console.Write (Ack(m,n));