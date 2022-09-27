// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Random myRand = new Random();
// Console.WriteLine("Введите m");
// int m = Convert.ToInt32(System.Console.ReadLine());
// Console.WriteLine("Введите n");
// int n = Convert.ToInt32(System.Console.ReadLine());
// double[,] array=new double[m,n];
//     for(int i=0;i<m;i++)
//     for(int j = 0; j < n; j++)
//         {
//             array[i, j]=Math.Round(myRand.NextDouble()*10-5,1);
//         }
//             for (int i = 0; i < m; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     Console.Write(array[i, j] + " ");
//                 }
//                 Console.WriteLine();
//             }



//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Random myRand = new Random();
// System.Console.WriteLine("Введите позиции элемента в массиве:");
// int m = Convert.ToInt32(System.Console.ReadLine());
// int n = Convert.ToInt32(System.Console.ReadLine());
// int sizeStrok= myRand.Next(4,10);
// int sizeStolb= myRand.Next(4,10);
// int[,] array=new int[sizeStrok,sizeStolb];
//     for(int i=0;i<sizeStrok;i++)
//         for(int j = 0; j < sizeStolb; j++)
//             {
//                 array[i, j] = myRand.Next(-10,10);
//             }
//         if((m>=sizeStrok)||(n>=sizeStolb)) System.Console.WriteLine("Элемента на таких позициях не существует");
//         else System.Console.WriteLine("Элемент на позициях ["+m+" "+n+"]: "+array[m,n]);



// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Random myRand = new Random();
System.Console.WriteLine("задайте размеры массива:");
int m = Convert.ToInt32(System.Console.ReadLine());
int n = Convert.ToInt32(System.Console.ReadLine());
double sum=0;
double[] arrayRes = new double[n];
int[,] array=new int[m,n];
for(int i=0;i<m;i++)
for(int j = 0; j < n; j++)
    {
        array[i, j] = myRand.Next(-10,10);
    }
    System.Console.WriteLine("Исходный массив:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    System.Console.Write(array[i,j]+" ");
                    sum += array[i, j];
                }
               
                System.Console.WriteLine();
                sum = 0;
            }
            for (int j = 0; j < n; j++)
            {
                double count = 0;
                for (int i = 0; i < m; i++)
                {
                    count = i;
                    sum += array[i, j];
                }
                arrayRes[j] = Math.Round( Convert.ToDouble(sum / (count+1)),1);
                sum = 0;
            }
            System.Console.WriteLine("Средние арифметические в столбцах");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arrayRes[i] + " ");
            }

