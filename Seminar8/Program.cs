// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

// Random myRand = new Random();
//             System.Console.WriteLine("задайте размеры массива:");
//             int m = Convert.ToInt32(System.Console.ReadLine());
//             int n = Convert.ToInt32(System.Console.ReadLine());
//             int tmp;
//             int[,] array = new int[m, n];
//             for (int i = 0; i < m; i++)
//                 for (int j = 0; j < n; j++)
//                 {
//                     array[i, j] = myRand.Next(-5, 10);
//                 }
//             System.Console.WriteLine("Исходный массив:");
//             for (int i = 0; i < m; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     System.Console.Write(array[i, j] + " ");

//                 }

//                 System.Console.WriteLine();

//             }
//             for (int i = 0; i < m; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {

//                     for (int t = j + 1; t < n; t++)
//                     {
//                         if (array[i, t] > array[i, j])
//                         {
//                             tmp = array[i, t];
//                              array[i, t] = array[i, j];
//                              array[i, j] = tmp;
//                         }
//                     }
//                 }



//             }
//             System.Console.WriteLine("Массив отсортированный в строках:");
//             for (int i = 0; i < m; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                    System.Console.Write(array[i, j] + " ");

//                 }

//                System.Console.WriteLine();
//             }


// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Random myRand = new Random();
//             System.Console.WriteLine("задайте размеры массива:");
//             int m = Convert.ToInt32(System.Console.ReadLine());
//             int n = Convert.ToInt32(System.Console.ReadLine());
//             int[,] array = new int[m, n];
//             for (int i = 0; i < m; i++)
//                 for (int j = 0; j < n; j++)
//                 {
//                     array[i, j] = myRand.Next(-5, 10);
//                 }
//             System.Console.WriteLine("Исходный массив:");
//             for (int i = 0; i < m; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     System.Console.Write(array[i, j] + " ");

//                 }

//                 System.Console.WriteLine();

//             }
//             int index = 0; 

//             int sumMin=0;
//             for (int j = 0; j < n; j++) sumMin += array[0, j];

//             for (int i = 0; i < m; i++)
//             {
//                 int sum = 0;
//                 for (int j = 0; j < n; j++)
//                 {
//                     sum += array[i, j];

//                 }
//                 if (sum < sumMin)
//                 {
//                     sumMin = sum;
//                     index = i;
//                 }


//             }
//             System.Console.WriteLine(index+" Строка с наименьшей суммой элементов");


// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Random myRand = new Random();
// System.Console.WriteLine("задайте размеры 1 массива:");
// int sizeStrokFirst = Convert.ToInt32(System.Console.ReadLine());
// int sizeStolbFirst = Convert.ToInt32(System.Console.ReadLine());
// int[,] array = new int[sizeStrokFirst, sizeStolbFirst];
// for (int i = 0; i < sizeStrokFirst; i++)
//     for (int j = 0; j < sizeStolbFirst; j++)
//     {
//         array[i, j] = myRand.Next(-5, 10);
//     }
// System.Console.WriteLine("Исходный 1 массив:");
// for (int i = 0; i < sizeStrokFirst; i++)
// {
//     for (int j = 0; j < sizeStolbFirst; j++)
//     {
//         System.Console.Write(array[i, j] + " ");

//     }

//     System.Console.WriteLine();

// }
// System.Console.WriteLine("задайте размеры 2 массива:");
// int sizeStrokSecond;
// int sizeStolbSecond;
// while (true)
// {
//     sizeStrokSecond = Convert.ToInt32(System.Console.ReadLine());
//     sizeStolbSecond = Convert.ToInt32(System.Console.ReadLine());
//     if (sizeStolbFirst==sizeStrokSecond)
//     {
//         break;
//     }
//     else
//     {
//         System.Console.WriteLine("Операция умножения матриц применима только если " +
//             "число столбцов в первой матрице равно числу строк во 2, введите заново:");
//     }
// }

// int[,] array2 = new int[sizeStrokSecond, sizeStolbSecond];
// for (int i = 0; i < sizeStrokSecond; i++)
//     for (int j = 0; j < sizeStolbSecond; j++)
//     {
//         array2[i, j] = myRand.Next(-5, 10);
//     }
// System.Console.WriteLine("Исходный 2 массив:");
// for (int i = 0; i < sizeStrokSecond; i++)
// {
//     for (int j = 0; j < sizeStolbSecond; j++)
//     {
//         System.Console.Write(array2[i, j] + " ");

//     }

//     System.Console.WriteLine();

// }
// int[,] resultMatrix = new int[sizeStrokFirst,sizeStolbSecond];
// System.Console.WriteLine("Результат умножения матриц:");
// for (int i = 0; i < sizeStrokFirst; i++){
//         for (int j = 0; j < sizeStolbSecond; j++)
//     {
//         resultMatrix[i, j] = 0;
//         for (int k = 0; k < sizeStolbFirst; k++)
//         {
//             resultMatrix[i, j] += array[i, k] * array2[k, j];
//         }
//         System.Console.Write(resultMatrix[i, j] + " ");
//     }
//     System.Console.WriteLine();
// }


//  Задайте значение N и напишите программу,которая выведет все натуральные числа в промежутке
// от N до 1. Выполнить с помощью рекурсии.


// Console.WriteLine("Задайте значение N");
// int N = Convert.ToInt32(Console.ReadLine());
// printNumbers(N);

// void printNumbers(int N){
// Console.WriteLine(N);
// if (N <= 1)return; 
// else printNumbers(N-1);
// }


// Задайте значение N и M. Напишите программу, которая найдет сумму натуральных элементов
// в промежутке от N до M.

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

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

        // Random myRand = new Random();
        //     System.Console.WriteLine("задайте размеры массива:");
        //     int x = Convert.ToInt32(System.Console.ReadLine());
        //     int y = Convert.ToInt32(System.Console.ReadLine());
        //     int z = Convert.ToInt32(System.Console.ReadLine());
        //     List<int> myList = new List<int>();
        //     for(int i = 10; i < 100; i++)
        //     {
        //         myList.Add(i);
        //     }
        //     int[,,] array = new int[x, y, z];
        //     int tmp = 0;
        //     for (int i = 0; i < x; i++)
        //     {
        //         for (int j = 0; j < y; j++)
        //         {
        //             for (int k = 0; k < z; k++)
        //             {
        //                 tmp = myRand.Next(0, (myList.Count - 1));
        //                 array[i, j, k] = myList[tmp];
        //                 myList.RemoveAt(tmp);
        //                 Console.Write(array[i, j, k] + "(" + i + "," + j + "," + k + ") ");
        //             }
        //             Console.WriteLine();
        //         }

        //     }

// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

string[,] array = new string[4,4];
            int n = 4;
            int i = 1, j, k, p = n / 2;
            for (k = 1; k <= p; k++)/*Цикл по номеру витка*/
            {

                for (j = k - 1; j < n - k + 1; j++)
                {
                    if (i <= 9) { array[k - 1, j] = "0" + i++; }
                    else { array[k - 1, j] = Convert.ToString( i++); }
                }
                for (j = k; j < n - k + 1; j++)
                {
                    if (i <= 9) { array[j, n - k] = "0" + i++; }
                    else { array[j, n - k] = Convert.ToString(i++); }
                }
                    for (j = n - k - 1; j >= k - 1; --j) 
                {
                    if (i <= 9) { array[n - k, j] = "0" + i++; }
                    else { array[n - k, j] = Convert.ToString(i++); }
                }
                    for (j = n - k - 1; j >= k; j--) 
                {
                    if (i <= 9) { array[j, k - 1] = "0" + i++; }
                    else { array[j, k - 1] = Convert.ToString(i++); }
                }
              
            }
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                {
                   System.Console.Write(array[i,j]+" ");
                    if (j == n - 1)Console.WriteLine();
                } 