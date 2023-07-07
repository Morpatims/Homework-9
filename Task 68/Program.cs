using System;
using static System.Console;

Clear();
Write("Enter M: ");
int M = Convert.ToInt32(ReadLine());
Write("Enter N: ");
int N = Convert.ToInt32(ReadLine());

WriteLine($"Ackerman function= {Akkerman(M, N)}");

int Akkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    if (N == 0)
    {
        return Akkerman(M - 1, 1);
    }
    return Akkerman(M - 1, Akkerman(M, N - 1));
}