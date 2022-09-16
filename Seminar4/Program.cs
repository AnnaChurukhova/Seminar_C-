// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.

// Console.WriteLine("Введите число А: ");
// int numA = Convert.ToInt32(System.Console.ReadLine());
// Console.WriteLine("Введите число В: ");
// int numB = Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine("Число А в степени В равно: "+Pow(numA,numB));
// static int Pow(int A,int B)
//     {
//     int result = 1;
//     for (int i = 0; i < B; i++)
//     {
//         result = result * A;
//     }
//     return result;
//     } 

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(System.Console.ReadLine());
// Count(num);       
// void Count(int num)
//     {
//     int sum = 0;
//     while (num > 0)
//     {
//     sum += num % 10;
//     num /= 10;
//     }
// System.Console.WriteLine(sum);
//     }


// int[] array = CreateArray();
// PrintArray(array);
PrintArray(CreateArray());
int[] CreateArray()
    {
    Console.WriteLine("Последовательно введите элементы массива");
        int[] array = new int[8];
        for (int i = 0; i < 8; i++)
        { 
            array[i] = Convert.ToInt32(System.Console.ReadLine());
        }
            return array;
    }
void PrintArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < 7; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.Write(array[7] + "]");
        }