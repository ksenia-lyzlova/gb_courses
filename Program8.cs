using System;
class Program8 {
  static void Main() {
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Четные числа до 1 до {number}:");
    for (int i = 1; i <= number; i++) {
        if (i % 2 == 0) {
            Console.WriteLine(i);
        }
    }
    Console.WriteLine("Все-го хоро-шего!");
  }
}