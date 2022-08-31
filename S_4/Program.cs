System.Console.WriteLine("Последовательно введите три числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2){
if (number1 > number3){
    System.Console.WriteLine(number1+" Первое число самое большое");
}
else {
    System.Console.WriteLine(number3+" Третье число самое большое");
}
}
if (number1 < number2) {
if (number2 > number3){
    System.Console.WriteLine(number2+" Второе число самое большое");
}
else {
    System.Console.WriteLine(number3+" Третье число самое большое");
}
}