using System;
using static System.Console;

Clear();
Write("Enter M: ");
int M = Convert.ToInt32(ReadLine());
Write("Enter N: ");
int N = Convert.ToInt32(ReadLine());

WriteLine(PrintNumbers(M, N));

string PrintNumbers(int M, int N)
{
    if (N == M)
    {
        return N.ToString();
    }
    return (N + " " + PrintNumbers(M, N - 1));
}