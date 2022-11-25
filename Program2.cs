using System;
class Program2 {
  static void Main() {
    Console.Write("Введите первое число: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    
    if (firstNumber > secondNumber) {
            Console.WriteLine($"Число {secondNumber} меньше {firstNumber}");
    } else {
            Console.WriteLine($"Число {secondNumber} больше {firstNumber}");
    }
    Console.WriteLine("Все-го хоро-шего!");
  }
}