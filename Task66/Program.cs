// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int numberM = 1;
int numberN = 15;
SumFromMToN(numberM, numberN, 0);

void SumFromMToN (int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"{sum}"); 
        return;
    }
    sum = sum + (numberM++);
    SumFromMToN(numberM, numberN, sum);
}
