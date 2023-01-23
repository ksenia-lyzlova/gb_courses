using System;
class Lab68
{
    static int Akk(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return Akk(m - 1, 1);
    else
      return Akk(m - 1, Akk(m, n - 1));
}
    static void Main(string[] args)
    {
        Console.Write("Введите число m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"A(m,n) = {Akk(m, n)}");
    }
}