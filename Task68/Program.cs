// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

int m = 2;
int n = 3;

int functionAck = Ack(m, n);
Console.Write($"{functionAck} ");

int Ack(int m, int n)
{
    if(m==0) return n + 1;
    else if((m != 0) && (n == 0)) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m,n - 1)); 
}

