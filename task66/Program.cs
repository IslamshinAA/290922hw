// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int PrintNumbers(int n , int  m )
{
if (m == n)
return n;
return PrintNumbers (n - 1,m) + n;
}


Console.WriteLine(PrintNumbers(15, 1));