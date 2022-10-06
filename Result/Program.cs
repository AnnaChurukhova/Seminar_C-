//Задача 64: Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// Console.WriteLine("Задайте значение N");
// int N = Convert.ToInt32(Console.ReadLine());
// printNumbers(N);

// void printNumbers(int N){
// Console.WriteLine(N);
// if (N <= 1)return; 
// else printNumbers(N-1);
// }


//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.WriteLine("Задайте значаение N");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задайте значаение M");
// int M = Convert.ToInt32(Console.ReadLine());
// printSum(N, M);

// void printSum(int N, int M){
// int sum=0;
// for(int i=N; i<=M; i++){
// }
// Console.WriteLine("Сумма элементов равна: "+sum);
// }

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29  

Console.Write("m = ");
int m =Convert.ToInt32(System.Console.ReadLine());
Console.Write("n = ");
int n =Convert.ToInt32(System.Console.ReadLine());
Console.Write("A(m,n) = "+A(m,n));
int A(int m, int n){
    if (m == 0){
    return n+1;
    }
    if (m>0 && n==0){
    return A(m-1,1);
    }
    if (m>0 && n>0){
    return A(m-1, A(m,n-1));
    }
    return 1;
}
