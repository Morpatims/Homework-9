using System;
using static System.Console;

Clear();
Write("Enter N: ");
int N = Convert.ToInt32(ReadLine());

WriteLine(PrintNumbers(N));

string PrintNumbers(int N)
{
    if (N == 1)
    {
        return N.ToString();
    }
    return (N + " " + PrintNumbers(N - 1));
}