using System;
class Lab10 {
  static void Main() {
    Console.Write("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    string str = number.ToString();
    Console.Write($"Вторая цифра в числе {number}: {str[1]}");
  }
}