// // Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// 5// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

    
// Console.WriteLine("Введите b1");
// int b1=Convert.ToInt32( Console.ReadLine());
// Console.WriteLine("Введите k1");
//             int k1 = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Введите b2");
//             int b2 = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Введите k2");
//             int k2 = Convert.ToInt32(Console.ReadLine());
//             Console.Write("("+crossingAbscissa(b1,k1,b2,k2)+("; "));
//             Console.Write(crossingAbscissa(b1,k1,b2,k2)*k1+b1+")");
    
//         static double abs(double num)
//         {
//             if (num > 0) return num;
//             if (num < 0) return -num;
//             return 0;
   
//         }
//         static double crossingAbscissa(int b1, int k1, int b2, int k2)
//         {
//             double b = b1 - b2;
//             double k = k1 - k2;

//             return -b / k;
//         }



// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел вы хотите ввести?");
           int num=Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Начинайте вводить числа");
            int count=0;
            for (int i = 0; i< num; i++)
            {
                int tmp = Convert.ToInt32(Console.ReadLine());
                if (tmp > 0) count++;
            }
            if(count>=5||count==0)Console.WriteLine(count+" Чисел больше 0");
            else if (count == 1){ Console.WriteLine(count + " Число больше 0"); }
            else { Console.WriteLine(count + " Числа больше 0"); }