using System;
class Cube {
  static void Main() {
    Console.Write("Введите любое число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= num; i++) {
        Console.Write($"{Math.Pow(i, 3)} ");
    }
  }
}