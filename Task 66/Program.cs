using System;
using static System.Console;

Clear();
Write("Enter M: ");
int M = Convert.ToInt32(ReadLine());
Write("Enter N: ");
int N = Convert.ToInt32(ReadLine());

WriteLine($"Sum of numbers = {SumNumbers(M, N)}");

int SumNumbers(int M, int N)
{
    if (M == N)
    {
        return M;
    }
    return (M + SumNumbers(M + 1, N));
}