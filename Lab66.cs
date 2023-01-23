using System;
class Lab66
{
    static int SumNumbers(int M, int N)
    {
        if (M == 0) {
            return (N * (N + 1)) / 2;
        }
        if (N == 0) {
            return (M * (M + 1)) / 2;
        }
        if (M == N) {
            return M;
        }
        if (M < N) {
            return N + SumNumbers(M, N - 1);
        } 
        return N + SumNumbers(M, N + 1);
    }
    static void Main(string[] args)
    {
        Console.Write("Введите число M: ");
        int M = int.Parse(Console.ReadLine());
        Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine($"Сумма чисел = {SumNumbers(M, N)}");
    }
}