﻿System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2) {
    System.Console.WriteLine(number1+" Первое число больше");
}
else if (number1 == number2) {
    System.Console.WriteLine("Оба числа равны");
}
else {
    System.Console.WriteLine(number2+ " Второе число больше первого");
}