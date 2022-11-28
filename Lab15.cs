using System;
class Lab15 {
  static void Main() {
    Console.Write("Введите цифру дня недели: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number >= 1 && number <= 7) {
        if (number >= 6) {
            Console.Write("Цэ выходной");
        } else {
            Console.Write("Эхх. Опять вкалывать");
        }
    } else {
        Console.Write("Не похоже на цифру дня недели. Попробуй еще");
    }
  }
}