// System.Console.WriteLine("Введите пятизначное число: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[5];
//     for (int i = 0; i < 5; i++)
//         {
//             array[i] = num % 10;
//             num = num / 10;
//         }
//     if(array[0]==array[4]&&array[1]==array[3]) 
// System.Console.WriteLine("Число палиндром");
//     else
// System.Console.WriteLine("Число не палиндром");

// System.Console.WriteLine("Введите координаты для точки A: ");
// int Xa, Ya, Za;
// int Xb, Yb, Zb;
// Xa = Convert.ToInt32(Console.ReadLine());
// Ya = Convert.ToInt32(Console.ReadLine());
// Za = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координаты для точки B: ");
// Xb = Convert.ToInt32(Console.ReadLine());
// Yb = Convert.ToInt32(Console.ReadLine());
// Zb = Convert.ToInt32(Console.ReadLine());
// double result = Rasstoyanie(Xa, Ya, Za, Xb, Yb, Zb);
// System.Console.WriteLine("Расстояние от точки А до точки В равно: "+result);
//       double Rasstoyanie(int Xa,int Ya,int Za,int Xb,int Yb,int Zb )
//         {
//             return Math.Sqrt(Math.Pow((Xa-Xb),2)+ Math.Pow((Ya - Yb), 2) + (Math.Pow((Za - Zb), 2)));
//         }

System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
    {
      System.Console.Write(Math.Pow(i, 3)+" ");
    }