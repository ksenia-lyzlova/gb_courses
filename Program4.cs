using System;
class Program4 {
  static void Main() {
    Console.Write("Введите первое число: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int thirdNumber = Convert.ToInt32(Console.ReadLine());
    int biggestNumber = Math.Max(Math.Max(firstNumber, secondNumber), thirdNumber);
    Console.WriteLine($"Самое большое число - {biggestNumber}");
    Console.WriteLine("Все-го хоро-шего!");
  }
}