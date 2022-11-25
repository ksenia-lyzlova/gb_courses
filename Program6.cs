using System;
class Program6 {
  static void Main() {
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number % 2 == 0)
   {
       Console.WriteLine($"Число {number} - четное");
   } else {
       Console.WriteLine($"Число {number} - нечетное");
   }
    Console.WriteLine("Все-го хоро-шего!");
  }
}