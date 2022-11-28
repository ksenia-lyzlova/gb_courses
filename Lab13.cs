using System;
class Lab13 {
  static void Main() {
    Console.Write("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    string str = number.ToString();
    if (str.Length > 2) {
        Console.Write($"Третья цифра в числе {number}: {str[2]}");
    } else {
        Console.Write("Третьей цифры нет");
    }
  }
}