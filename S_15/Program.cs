Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 6 && num > 0) {
    Console.WriteLine("Не выходной");
}
else if (num > 5 && num < 8) {
    Console.WriteLine("Выходной");
}
else {
    Console.WriteLine("Этого дня недели не существует");
}
