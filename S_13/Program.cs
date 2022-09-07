System.Console.WriteLine ("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
char [] arrNum = num.ToString().ToCharArray();
if (arrNum.Length > 2) {
    System.Console.WriteLine(arrNum[arrNum.Length - 3]);
}
else {
    System.Console.WriteLine("Третьей цифры нет");
}